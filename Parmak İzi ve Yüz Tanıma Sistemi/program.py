from PyQt5.QtWidgets import QMainWindow,QApplication,QPushButton,QLabel,QVBoxLayout,QMessageBox,QLineEdit
from PyQt5.Qt import QTimer,QImage
import sys
from PyQt5 import QtGui
from PyQt5.QtGui import QPixmap
from PyQt5.QtCore import QRect
from PyQt5 import QtCore
import numpy as np
import cv2
from imutils import face_utils
import os
import json
import dlib
from PIL import Image 
import serial
import time

class YeniYuzEkle(QMainWindow):

    def __init__(self):
        super().__init__()
        self.top=100
        self.left=100
        self.right=500
        self.bottom=440
        self.formIcon="icon.png"
        self.init_window()

    def init_window(self):
        self.setWindowTitle("Yeni Admin Tanımlama Ekranı")
        self.setWindowIcon(QtGui.QIcon(self.formIcon)) # form için ikon oluşturma
        self.setGeometry(self.top,self.left,self.right,self.bottom)
        self.girisParmakIziSetUI()
        self.show
        #self.girisOnay()   

    def girisParmakIziSetUI(self):
        label = QLabel(self)
        pix = QPixmap("yuztanima.png")
        label.setPixmap(pix)   
        label.setGeometry(QRect( 0, 0, pix.width(), pix.height()-50))
        self.textboxId=QLineEdit(self)
        self.textboxId.setAlignment(QtCore.Qt.AlignCenter)
        self.textboxId.setGeometry(QRect(0,370,500,20))
        kaydetButton=QPushButton(self)
        kaydetButton.setText("Ismi ile Kaydet")
        kaydetButton.setGeometry(QRect(0,400,500,20))
        kaydetButton.clicked.connect(self.kaydetClick)
        self.label2 = QLabel(self)
        self.label2.setText("")
        self.label2.setAlignment(QtCore.Qt.AlignCenter)
        self.label2.setGeometry( QRect( 0, 430, 500, 10))

    def kaydetClick(self):
        cam= cv2.VideoCapture(0)
        face_detector=cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
        global user
        user=self.textboxId.text()
        self.label2.setText("\n [Bilgi] Kameraya bakın ve bekleyin...")
        say=0
        os.mkdir('images/'+user)
        self.label2.setText("kaydet")
        while(True):
            ret, cerceve=cam.read()
            cerceve=cv2.flip(cerceve,1)
            gri = cv2.cvtColor(cerceve, cv2.COLOR_BGR2GRAY)
            faces=face_detector.detectMultiScale(gri,1.5,5)

            for (x,y,w,h)in faces:
            
                cv2.rectangle(cerceve, (x, y), (x + w, y + h), (0, 255, 0), 2)
                print (x,y,w,h)
                say=say+1
                self.label2.setText("Çekilen resim sayısı:"+str(say))
                path="images/"+user+"/"
                cv2.imwrite(path+str(say)+".jpg",gri[y:y+h,x:x+w])
                cv2.imshow('Kayıt Ekranı', cerceve)
            k=cv2.waitKey(100) & 0xFF
            if k==27:
                break 
            elif say>=30:
                break
            
                    
        cam.release()
        cv2.destroyAllWindows()


class KullaniciSil(QMainWindow):

    def __init__(self):
        super().__init__()
        self.port = serial.Serial("COM12",300,timeout=1)
        time.sleep(2)
        self.port.flush()
        time.sleep(1)
        self.control=False
        self.str1='1'

        self.timer = QTimer()
        self.timer.timeout.connect(self.girisOnay)
        
        self.top=100
        self.left=100
        self.right=500
        self.bottom=440
        self.formIcon="icon.png"
        self.programMenuEkrani = ProgramMenuEkrani()
        self.init_window()
        
    def init_window(self):
        self.setWindowTitle("Kullanıcı Silme Ekranı")
        self.setWindowIcon(QtGui.QIcon(self.formIcon)) # form için ikon oluşturma
        self.setGeometry(self.top,self.left,self.right,self.bottom)
        self.girisParmakIziSetUI()
        self.show
        self.girisOnay()

    def silClick(self):
        self.port.write(b'Sil')
        self.timer.start(1000./10)
        a=self.textboxId.text()
        time.sleep(2)
        print(bytes(a, 'utf8'))
        self.port.write(bytes(a, 'utf8'))
    
    def closeEvent(self, event):
        self.port.close()

    def girisParmakIziSetUI(self):
        label = QLabel(self)
        pix = QPixmap("parmakizi.jpg")
        label.setPixmap(pix)   
        label.setGeometry(QRect( 0, 0, pix.width(), pix.height()-50))
        self.textboxId=QLineEdit(self)
        self.textboxId.setAlignment(QtCore.Qt.AlignCenter)
        self.textboxId.setGeometry(QRect(0,370,500,20))
        kaydetButton=QPushButton(self)
        kaydetButton.setText("Idyi Sil")
        kaydetButton.setGeometry(QRect(0,400,500,20))
        kaydetButton.clicked.connect(self.silClick)
        self.label2 = QLabel(self)
        self.label2.setText(self.port.readline().decode('unicode_escape'))
        self.label2.setAlignment(QtCore.Qt.AlignCenter)
        self.label2.setGeometry( QRect( 0, 430, 500, 10))
    
    def girisOnay(self):
        self.label2.setText(self.port.readline().decode('unicode_escape'))
        if(self.label2.text()=="1\r\n"):
            self.port.close()
            self.timer.stop()
            self.hide()



class YeniKullaniciTanımla(QMainWindow):

    def __init__(self):
        super().__init__()
        self.port = serial.Serial("COM12",300,timeout=1)
        time.sleep(2)
        self.port.flush()
        time.sleep(1)
        self.control=False
        self.str1='1'

        self.timer = QTimer()
        self.timer.timeout.connect(self.girisOnay)
        
        self.top=100
        self.left=100
        self.right=500
        self.bottom=440
        self.formIcon="icon.png"
        self.programMenuEkrani = ProgramMenuEkrani()
        self.init_window()
        
    def init_window(self):
        self.setWindowTitle("Giriş Ekranı")
        self.setWindowIcon(QtGui.QIcon(self.formIcon)) # form için ikon oluşturma
        self.setGeometry(self.top,self.left,self.right,self.bottom)
        self.girisParmakIziSetUI()
        self.show
        self.girisOnay()

    def closeEvent(self, event):
        self.port.close()

    def kaydetClick(self):
        self.port.write(b'Kayit')
        self.timer.start(1000./10)
        a=self.textboxId.text()
        time.sleep(2)
        print(bytes(a, 'utf8'))
        self.port.write(bytes(a, 'utf8'))
        

    def girisParmakIziSetUI(self):
        label = QLabel(self)
        pix = QPixmap("parmakizi.jpg")
        label.setPixmap(pix)   
        label.setGeometry(QRect( 0, 0, pix.width(), pix.height()-50))
        self.textboxId=QLineEdit(self)
        self.textboxId.setAlignment(QtCore.Qt.AlignCenter)
        self.textboxId.setGeometry(QRect(0,370,500,20))
        kaydetButton=QPushButton(self)
        kaydetButton.setText("Idye Kaydet")
        kaydetButton.setGeometry(QRect(0,400,500,20))
        kaydetButton.clicked.connect(self.kaydetClick)
        self.label2 = QLabel(self)
        self.label2.setText(self.port.readline().decode('unicode_escape'))
        self.label2.setAlignment(QtCore.Qt.AlignCenter)
        self.label2.setGeometry( QRect( 0, 430, 500, 10))
    
    def girisOnay(self):
        self.label2.setText(self.port.readline().decode('unicode_escape'))
        if(self.label2.text()=="1\r\n"):
            self.port.close()
            self.timer.stop()
            self.hide()


class ProgramAdminMenuEkrani(QMainWindow):
    def __init__(self):
        super().__init__()
        self.top=100
        self.left=100
        self.right=500
        self.bottom=440
        self.formIcon="icon.png"
        self.init_window()

    def init_window(self):
        self.setWindowTitle("Menu Ekranı")
        self.setWindowIcon(QtGui.QIcon(self.formIcon)) # form için ikon oluşturma
        self.setGeometry(self.top,self.left,self.right,self.bottom)
        self.menuEkraniUI()

    def yeniadminclicked(self):
        self.yeniAdminTanımla=YeniYuzEkle()
        self.yeniAdminTanımla.show()

    def yenikulclicked(self):
        self.yeniKullaniciTanımla = YeniKullaniciTanımla()
        self.yeniKullaniciTanımla.show()

    def kulsilclicked(self):
        self.kullaniciSil=KullaniciSil()
        self.kullaniciSil.show()

    def menuEkraniUI(self):
        self.yeniAdminButton = QPushButton(self)
        self.yeniAdminButton.setText("Yeni Admin Tanimla")
        self.yeniAdminButton.setGeometry(QRect( 10, 10, self.right-20, 136))
        self.yeniAdminButton.clicked.connect(self.yeniadminclicked)
        self.yeniKullaniciButton = QPushButton(self)
        self.yeniKullaniciButton.setText("Yeni Kullanici Tanimla")
        self.yeniKullaniciButton.setGeometry( QRect( 10, 146, self.right-20, 136))
        self.yeniKullaniciButton.clicked.connect(self.yenikulclicked)
        self.kullaniciSilButton = QPushButton(self)
        self.kullaniciSilButton.setText("Kullanici Sil")
        self.kullaniciSilButton.setGeometry( QRect( 10, 282, self.right-20, 136))
        self.kullaniciSilButton.clicked.connect(self.kulsilclicked)
    


class ProgramYuzTanimaEkrani(QMainWindow):
    
    yol='images'
    tani=cv2.face.LBPHFaceRecognizer_create()
    detector=cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
    cascadePath=('haarcascade_frontalface_default.xml')
    faceCascade=cv2.CascadeClassifier(cascadePath);
    font=cv2.FONT_HERSHEY_SIMPLEX
    id=0

    dictionary={}
    names=[]
    dosya=open("ids.json","r")
    dictionary=json.load(dosya)
    
    def getImagesAndLabels(self, yol):
        faceSamples=[]
        ids=[]
        labels=[]
        klasorler=os.listdir(yol)
    
        self.dictionary={}
        for i,k1 in enumerate(klasorler):
            self.dictionary[k1]=int(i)

        f=open("ids.json","w")
        a=json.dump(self.dictionary,f)
        f.close()
        for k1 in klasorler:
            for res in os.listdir(os.path.join(yol,k1)):
                PIL_img=Image.open(os.path.join(yol,k1,res)).convert('L')
                img_numpy=np.array(PIL_img,'uint8')
                id=int(self.dictionary[k1])
                faces=self.detector.detectMultiScale(img_numpy)
                for(x,y,w,h)in faces:
                    faceSamples.append(img_numpy[y:y+h,x:x+w])
                    ids.append(id)
        return faceSamples,ids

    def __init__(self):
        super().__init__()

        # Create a timer.
        self.timer = QTimer()
        self.timer.timeout.connect(self.nextFrameSlot)

        self.top=100
        self.left=100
        self.right=640
        self.bottom=360
        self.setGeometry(self.top,self.left,self.right,self.bottom)
        self.formIcon="icon.png"
        self.label = QLabel(self)
        self.label.setFixedSize(640, 360)
        dir_path = os.path.dirname(os.path.realpath(__file__))
        filename = os.path.join(dir_path, 'image.tif')
        self.pixmap = self.resizeImage(filename)
        self.label.setStyleSheet("background-color: rgb(0, 0, 0);")
        self.label.setPixmap(self.pixmap)
        self.openCamera()

    def closeEvent(self, event):
    
        msg = "Uygulamayı kapatmak istiyor musun?"
        reply = QMessageBox.question(self, 'Message', 
                        msg, QMessageBox.Yes, QMessageBox.No)

        if reply == QMessageBox.Yes:
            event.accept()
            self.stopCamera()
        else:
            event.ignore()

    def resizeImage(self, filename):
        self.pixmap = QPixmap(filename)
        lwidth = self.label.maximumWidth()
        pwidth = self.pixmap.width()
        lheight = self.label.maximumHeight()
        pheight = self.pixmap.height()

        wratio = pwidth * 1.0 / lwidth
        hratio = pheight * 1.0 / lheight

        if pwidth > lwidth or pheight > lheight:
            if wratio > hratio:
                lheight = pheight / wratio
            else:
                lwidth = pwidth / hratio

            scaled_pixmap = self.pixmap.scaled(lwidth, lheight)
            return scaled_pixmap
        else:
            return self.pixmap

    def openCamera(self):
        faces,ids=self.getImagesAndLabels(self.yol)
        self.tani.train(faces,np.array(ids))
        self.tani.write('trainer.yml')

        self.tani=cv2.face.LBPHFaceRecognizer_create()
        self.tani.read('trainer.yml')
        
        #cam=cv2.VideoCapture(0)

        for key,value in self.dictionary.items():
            self.names.append(key)
        
        self.vc = cv2.VideoCapture(0)
        # vc.set(5, 30)  #set FPS
        self.vc.set(3, 640) #set width
        self.vc.set(4, 480) #set height

        if not self.vc.isOpened(): 
            msgBox = QMessageBox()
            msgBox.setText("Kamera başlatılamadı.")
            msgBox.exec_()
            return

        self.timer.start(1000./24)
    
    def stopCamera(self):
        self.timer.stop()

    def nextFrameSlot(self):
        rval, frame = self.vc.read()
        frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        gri = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        faces=self.faceCascade.detectMultiScale(gri ,scaleFactor=1.5 , minNeighbors=5)
        self.label.setPixmap(self.pixmap)
        for (x,y,w,h)in faces:
            cv2.rectangle(frame, (x, y), (x + w, y + h), (0, 255, 0), 2)
            id,oran=self.tani.predict(gri[y:y+h,x:x+w])
            print (id)
            if(oran<70):
                id=self.names[id]
                msg = "Girişiniz Onaylandı: "+str(id)
                reply = QMessageBox.information(self, 'Message', 
                        msg, QMessageBox.Ok)

                if reply == QMessageBox.Ok:
                    self.stopCamera()
                    self.programAdminMenuEkrani=ProgramAdminMenuEkrani()
                    self.programAdminMenuEkrani.show()
                    self.hide()
            else:
                id="Bilinmiyor"
            cv2.putText(frame,str(id),(x+5,y-5),self.font , 1 ,(255,255,255),2)
            #k=cv2.waitKey(100) & 0xFF
        image = QImage(frame, frame.shape[1], frame.shape[0], QImage.Format_RGB888)
        self.pixmap = QPixmap.fromImage(image)

    def getImagesAndLabels(self, yol):
        faceSamples=[]
        ids=[]
        labels=[]
        klasorler=os.listdir(yol)
    
        self.dictionary={}
        for i,k1 in enumerate(klasorler):
            self.dictionary[k1]=int(i)

        f=open("ids.json","w")
        a=json.dump(self.dictionary,f)
        f.close()
        for k1 in klasorler:
            for res in os.listdir(os.path.join(yol,k1)):
                PIL_img=Image.open(os.path.join(yol,k1,res)).convert('L')
                img_numpy=np.array(PIL_img,'uint8')
                id=int(self.dictionary[k1])
                faces=self.detector.detectMultiScale(img_numpy)
                for(x,y,w,h)in faces:
                    faceSamples.append(img_numpy[y:y+h,x:x+w])
                    ids.append(id)
        return faceSamples,ids
    
    

class ProgramMenuEkrani(QMainWindow):
    def __init__(self):
        super().__init__()
        self.top=100
        self.left=100
        self.right=500
        self.bottom=440
        self.formIcon="icon.png"
        self.init_window()

    def init_window(self):
        self.setWindowTitle("Menu Ekranı")
        self.setWindowIcon(QtGui.QIcon(self.formIcon)) # form için ikon oluşturma
        self.setGeometry(self.top,self.left,self.right,self.bottom)
        self.menuEkraniUI()

    def clicked(self):
        self.programYuzTanimaEkrani = ProgramYuzTanimaEkrani()
        self.programYuzTanimaEkrani.show()
        self.hide()

    def menuEkraniUI(self):
        self.genelProgramButton = QPushButton(self)
        self.genelProgramButton.setText("Genel İşlemler")
        self.genelProgramButton.setGeometry( QRect( 10, 10, self.right-20, 210))
        self.adminGirisButton = QPushButton(self)
        self.adminGirisButton.setText("Admin Girişi")
        self.adminGirisButton.setGeometry( QRect( 10, 220, self.right-20, 210))
        self.adminGirisButton.clicked.connect(self.clicked)
    
    


class ParmakIziGirisEkrani(QMainWindow):

    def __init__(self):
        super().__init__()
        self.port = serial.Serial("COM12",300,timeout=1)
        time.sleep(2)
        self.port.flush()
        time.sleep(1)
        self.control=False
        self.str1='1'
        self.port.write(b'Okut')
        self.timer = QTimer()
        self.timer.timeout.connect(self.girisOnay)
        self.timer.start(1000./10)

        self.top=100
        self.left=100
        self.right=500
        self.bottom=440
        self.formIcon="icon.png"
        self.programMenuEkrani = ProgramMenuEkrani()
        self.init_window()
        
    def init_window(self):
        self.setWindowTitle("Giriş Ekranı")
        self.setWindowIcon(QtGui.QIcon(self.formIcon)) # form için ikon oluşturma
        self.setGeometry(self.top,self.left,self.right,self.bottom)
        self.girisParmakIziSetUI()
        self.show
        self.girisOnay()


    def girisParmakIziSetUI(self):
        label = QLabel(self)
        pix = QPixmap("parmakizi.jpg")
        label.setPixmap(pix)   
        label.setGeometry(QRect( 0, 0, pix.width(), pix.height()))

        label2 = QLabel(self)
        label2.setText("Lütfen Parmak İzinizi Okutunuz.")
        label2.setAlignment(QtCore.Qt.AlignCenter)
        label2.setGeometry( QRect( 0, 410, 500, 10))
    
    def girisOnay(self):
        #time.sleep(1)
        if(self.control==False):
            self.str1=self.port.readline().decode('unicode_escape')
        else:
            self.str1=self.port.readline().decode('unicode_escape')
            if(self.str1==""):
                self.str1=0
            else:
                self.str1=int(self.str1)
            
        if(self.str1=="Okut\r\n" or self.str1=="-1\r\n"):
            self.control=True
            self.str1=0
        print(self.str1)
        if(self.control==True):
            if(self.str1!=0 and self.str1!=-1):
                self.programMenuEkrani.show()
                self.timer.stop()
                self.port.close()
                self.hide()
                

if __name__ == '__main__': # Programın başlayacağı main metodu

    app=QApplication(sys.argv)
    window=ParmakIziGirisEkrani()
    window.show()
    app.exit(app.exec())
