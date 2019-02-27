# Görüntü İşleme Teknikleri Kullanılarak Yemekhane Otomasyonunun Gerçekleştirilmesi

Projenin Amacı
	Yemekhane turnikesinin önüne takılan kamera yardımı ile alınan kullanıcıların görüntülerinden görüntü işleme tekniği ile kimlik tespiti yapılıp yemekhane otomasyonunun yapılması amaçlanmaktadır.
Giriş
	Günlük hayatta yapılan her türlü işlemlerde zaman, hız ve güvenilirlik önem taşır[1]. Örneğin bir yemekhane kapısında, kişilerin her giriş ve çıkışlarında kart okutmaları ya da benzeri yöntemler kullanmaları kaçınılmaz olmaktadır. Fakat kullanılan bu yöntemlerin güvenli olması gerekmektedir. Bunun içinde her geçen gün farklı metotlar ortaya konulmaktadır. Kameradan kimlik tespiti de bu yöntemlerden biridir. Bu kapsamda birçok yüz tanıma teknikleri ve algoritmaları araştırılmıştır. Proje çalışmasında yüz tanıma sistemine iki boyutlu yaklaşılmış ve bu konuda çözüm üretilmeye çalışılmıştır. Öncelikle yüz algılama kısmı tasarlanmıştır. Bu yöntem kullanılırken C# dilinde EmguCv[2] ve OpenCv[3] Kütüphaneleri kullanılmıştır. İkinci olarak ise yüz tanıma kısmı tasarlanmıştır ve yemekhane otomasyonu gerçekleştirilmiştir.	
	
Yöntem
	
1-Algoritma ve Akış Diyagramı:
A-Yüz Kayıt Algoritması
-	Kamera görüntüsünün alınması ve yazılıma girdi olarak verilmesi.
-	Alınan görüntüsündeki yüz ifadesinin Haar Cascade algoritması[4-6] kullanılarak bulunması  ve işaretlenmesi.
-	Yüzün bulunduğu bölgenin kırpılması ve kaydedilmesi.
-	Aynı kişiye ait yüz ifadelerinin en az 20 farklı kaydının yapılması ve kişiye ait kimlik bilgilerinin veri tabanına kaydedilmesi.
 

B-Yüz Tanıma Algoritması
-	Kamera görüntüsünün alınması ve yazılıma girdi olarak verilmesi.
-	Alınan görüntüsündeki yüz ifadesinin Haar Cascade algoritması[4-6] kullanılarak bulunması  ve işaretlenmesi.
-	Algılanan yüz ifadesinin veri tabanındaki kayıtların EigenFace yöntemi [7-9] ile karşılaştırılması.
-	Veri tabanındaki kayıtlı ise hesabındaki kredinin kontrolü ve kredi düşümünün yapılması.
-	Turnike sisteminden geçişe izin verilmesi
	

2-Gerçekleşme:
	Yukarda belirtilen algoritmalar OpenCv ve EmguCv Kütüphanesi kullanılarak gerçekleştirilmiştir.
Çalışmamızda  yüz ifadelerinden kimlik tespiti için Temel Bileşen Analizi Tabanlı Eigenface Algoritması[10] kullanılmıştır. Bu metot ten rengi gibi faktörlerden en az etkilenen metottur ve de bu metotta gözlük gibi yüz üstüne giyilen materyaller (Göz, burun veya ağızı kapatmadığı sürece) kişiyi tanımaya engel olmamaktadır. Lakin ışık etmeni yüzü tanımada engel çıkartabilmektedir. Şekil-3’te kişiye ait yüz ifadeleri ve Eigenface yöntemi ile eğitilmiş yüz örnekleri bulunmaktadır.


Sonuç ve Tartışmalar
	Çalışmamız 3 erkek 3 kız toplam 6 kişi üzerinde denenmiştir. Yapılan testlerde kişinin gözlük takıp takmamasının sistemin başarısını etkilemediği görülmüştür. Farklı ışık ortamlarında olumsuz etkileri olduğu tespit edilmiştir. Bunu engellemek için kişiler kayıt edilirken farklı ışık ortamları kullanılabilir. Şekil 4’te yazılımın ait örnek ekran görüntüsü bulunmaktadır.

Genel olarak yazılımın başarıya ulaştığı görülmüş ve sistemin otomasyonu gerçekleştirilmiştir. İleriki çalışmalarda görüntülerin tanınması için daha farklı algoritmalar üzerinde çalışılabilir.




Kaynaklar
[1]	Yüz tanıma Selçuk Başak C# kullanımı, www.selcukbasak.com/download/YuzTanima-Proje.pdf
[2] www.emgu.com/
[3] opencv.org
[4]	http://fewtutorials.bravesites.com/entries/emgu-cv-c/level-3---live-face-detection
[5] http://docs.opencv.org/trunk/doc/py_tutorials/py_objdetect/py_face_detection/ py_face_detection.html
[6] http://www.emgu.com/wiki/files/2.3.0/document/html/11c784fc-7d30-a921-07ec-ecdb7d217bbe.htm
[7] Lata, Y. Vijaya, et al. "Facial recognition using eigenfaces by PCA." International Journal of Recent Trends in Engineering 1.1 (2009): 587-590.
[8] http://www.face-rec.org/algorithms/PCA/jcn.pdf
[9]  Ahmet Yıldırım ERDOĞAN, Ankara Üniversitesi Elektronik Mühendisliği Ana Bilim Dalı " , Yüz Tanımada Özyüz Ve Fisher Yüz Algoritmalarının İncelenmesi"
[10]	Eleyan, Alaa, and Hasan Demirel. "Multiresolution eigenspace and fisherspace face recognition." Signal Processing, Communication and Applications Conference, 2008. SIU 2008. IEEE 16th. IEEE, 2008.

