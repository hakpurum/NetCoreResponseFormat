<p>Merhaba Arkadaşlar,</p>
<p>Bu b&ouml;l&uuml;mde sizlere .Net Core 2.0 &ccedil;atısı altında <strong>Response Formatter</strong> filter'ı geliştirerek action larımızı ve viewresult larımızı nasıl daha esnek kullanacağımızı anlatmaya &ccedil;alışıcam.Amacımız projemiizde yazılmış olan action larımıza json ve xml response larını filter yatarak attribute ile dışarıya servis etmek.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/14.jpg" alt="" width="786" height="513" /></p>
<p>&Ouml;ncelikle bir tane .Net Core 2.0 projesi a&ccedil;ıyoruz.(Ben vs 2017 kullanıyorum) Projemizi a&ccedil;tıktan sonra&nbsp;<strong>Microsoft.AspNetCore.Mvc.Formatters.Xml.Extensions</strong> paketini nuget &uuml;zerinden dahil ediyoruz. Bu paketi xml formatında verilerimizi d&ouml;nmek i&ccedil;in kullanacağız.</p>
<p><strong>Nuget :&nbsp;Install-Package Microsoft.AspNetCore.Mvc.Formatters.Xml.Extensions -Version 2.0.0</strong></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/1.jpg" alt="" width="815" height="259" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/2.jpg" alt="" width="425" height="388" /></p>
<p>İşlem tamamlandıktan sonra<strong> StartUp.cs</strong> dosyasına gelerek genişletilmiş method olan&nbsp;<br /><strong>AddXmlFormaterExtensions()</strong> methodunu ekliyoruz.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/3.jpg" alt="" width="1364" height="726" /></p>
<p>Sonrasında projemizde <strong>Filters</strong> klas&ouml;r&uuml; altına&nbsp;<strong>FormatReponseFilter</strong> isimli <strong>attribute</strong> sınıfımızı ekliyoruz.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/4.jpg" alt="" width="1449" height="934" /></p>
<p>Kısaca buradaki methodların işleyişinden bahsedicem.</p>
<p>Controller a istek geldiğinde&nbsp;<strong>OnActionExecuting</strong> methodu &ccedil;alışacak format parametereli <strong>querystring</strong> den gelen değeri alıcak ve&nbsp;<strong>RequestedType</strong> isimli değişkenimize set edicek.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/5.jpg" alt="" width="1671" height="934" /></p>
<p>Ardından&nbsp;<strong>OnActionExecuted</strong> methoduna giricek burada format tipine g&ouml;re <strong>Result'ı</strong> set edicek. Burada result'ın <strong>model</strong> deki verilerine erişmemiz i&ccedil;in&nbsp;<strong>ModelFromActionResult</strong> methodunu kullanacak. Size bu method daki case leri istediğiniz kadar genişletebilirsiniz. Ama zaten bu methoda sadece&nbsp;<strong>ViewResult</strong> veya&nbsp;<strong>PartialViewResult</strong> gibi <strong>model</strong> d&ouml;nebildiğimiz y&ouml;ntemlerde girecek.Bu method &uuml;zerinden <strong>model</strong> <strong>return</strong> edilecek ve <strong>json</strong> yada <strong>xml</strong> e d&ouml;n&uuml;şt&uuml;r&uuml;lerek&nbsp;<strong>Result</strong> nesnesine set edilecektir.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/6.jpg" alt="" width="1671" height="934" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/7.jpg" alt="" width="1671" height="934" /></p>
<p>Ben herhangi bir veritabanı kullanmadan direk statik verilerle &ccedil;alışacağımdan&nbsp;<strong>Models</strong> klas&ouml;r&uuml; altına&nbsp;<strong>UserModel</strong> isimli bir class ekledim. <strong>HomeController/Index</strong> te statik veriyi oluşturarak <strong>View</strong> e return ettim.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/8.jpg" alt="" width="1364" height="726" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/9.jpg" alt="" width="1671" height="934" /></p>
<p>Sadece bu actiona <strong>json</strong> ve <strong>xml</strong> formatını dahil etmek istediğim i&ccedil;in&nbsp; <strong>[FormatReponseFilter]</strong> attribute &uuml;n&uuml; ekledim.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/10.jpg" alt="" width="1671" height="934" /></p>
<p>B&uuml;t&uuml;n işlemlerimiz tamamlandı. Artık bu action'ımıza <strong>json</strong> ve <strong>xml</strong> &ouml;zelliğide kazandırmış olduk. Tek yapmamız gereken <strong>?format=json</strong> yada&nbsp;<strong>?format=json</strong> parametresini koyarak action ımızı &ccedil;ağırmak.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/11.jpg" alt="" width="951" height="569" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/12.jpg" alt="" width="950" height="235" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/13.jpg" alt="" width="952" height="446" /></p>
<p>Umarım faydalı bir makale olmuştur</p>
<p>Saygılarımla</p>
<p><a href="https://github.com/hakpurum/NetCoreResponseFormat/" rel="noopener noreferrer" target="_blank"><span style="font-size: 18px;">Proje Github Kaynağı İçin Tıklayın</span></a></p><p>Merhaba Arkadaşlar,</p>
<p>Bu b&ouml;l&uuml;mde sizlere .Net Core 2.0 &ccedil;atısı altında <strong>Response Formatter</strong> filter'ı geliştirerek action larımızı ve viewresult larımızı nasıl daha esnek kullanacağımızı anlatmaya &ccedil;alışıcam.Amacımız projemiizde yazılmış olan action larımıza json ve xml response larını filter yatarak attribute ile dışarıya servis etmek.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/14.jpg" alt="" width="786" height="513" /></p>
<p>&Ouml;ncelikle bir tane .Net Core 2.0 projesi a&ccedil;ıyoruz.(Ben vs 2017 kullanıyorum) Projemizi a&ccedil;tıktan sonra&nbsp;<strong>Microsoft.AspNetCore.Mvc.Formatters.Xml.Extensions</strong> paketini nuget &uuml;zerinden dahil ediyoruz. Bu paketi xml formatında verilerimizi d&ouml;nmek i&ccedil;in kullanacağız.</p>
<p><strong>Nuget :&nbsp;Install-Package Microsoft.AspNetCore.Mvc.Formatters.Xml.Extensions -Version 2.0.0</strong></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/1.jpg" alt="" width="815" height="259" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/2.jpg" alt="" width="425" height="388" /></p>
<p>İşlem tamamlandıktan sonra<strong> StartUp.cs</strong> dosyasına gelerek genişletilmiş method olan&nbsp;<br /><strong>AddXmlFormaterExtensions()</strong> methodunu ekliyoruz.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/3.jpg" alt="" width="1364" height="726" /></p>
<p>Sonrasında projemizde <strong>Filters</strong> klas&ouml;r&uuml; altına&nbsp;<strong>FormatReponseFilter</strong> isimli <strong>attribute</strong> sınıfımızı ekliyoruz.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/4.jpg" alt="" width="1449" height="934" /></p>
<p>Kısaca buradaki methodların işleyişinden bahsedicem.</p>
<p>Controller a istek geldiğinde&nbsp;<strong>OnActionExecuting</strong> methodu &ccedil;alışacak format parametereli <strong>querystring</strong> den gelen değeri alıcak ve&nbsp;<strong>RequestedType</strong> isimli değişkenimize set edicek.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/5.jpg" alt="" width="1671" height="934" /></p>
<p>Ardından&nbsp;<strong>OnActionExecuted</strong> methoduna giricek burada format tipine g&ouml;re <strong>Result'ı</strong> set edicek. Burada result'ın <strong>model</strong> deki verilerine erişmemiz i&ccedil;in&nbsp;<strong>ModelFromActionResult</strong> methodunu kullanacak. Size bu method daki case leri istediğiniz kadar genişletebilirsiniz. Ama zaten bu methoda sadece&nbsp;<strong>ViewResult</strong> veya&nbsp;<strong>PartialViewResult</strong> gibi <strong>model</strong> d&ouml;nebildiğimiz y&ouml;ntemlerde girecek.Bu method &uuml;zerinden <strong>model</strong> <strong>return</strong> edilecek ve <strong>json</strong> yada <strong>xml</strong> e d&ouml;n&uuml;şt&uuml;r&uuml;lerek&nbsp;<strong>Result</strong> nesnesine set edilecektir.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/6.jpg" alt="" width="1671" height="934" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/7.jpg" alt="" width="1671" height="934" /></p>
<p>Ben herhangi bir veritabanı kullanmadan direk statik verilerle &ccedil;alışacağımdan&nbsp;<strong>Models</strong> klas&ouml;r&uuml; altına&nbsp;<strong>UserModel</strong> isimli bir class ekledim. <strong>HomeController/Index</strong> te statik veriyi oluşturarak <strong>View</strong> e return ettim.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/8.jpg" alt="" width="1364" height="726" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/9.jpg" alt="" width="1671" height="934" /></p>
<p>Sadece bu actiona <strong>json</strong> ve <strong>xml</strong> formatını dahil etmek istediğim i&ccedil;in&nbsp; <strong>[FormatReponseFilter]</strong> attribute &uuml;n&uuml; ekledim.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/10.jpg" alt="" width="1671" height="934" /></p>
<p>B&uuml;t&uuml;n işlemlerimiz tamamlandı. Artık bu action'ımıza <strong>json</strong> ve <strong>xml</strong> &ouml;zelliğide kazandırmış olduk. Tek yapmamız gereken <strong>?format=json</strong> yada&nbsp;<strong>?format=json</strong> parametresini koyarak action ımızı &ccedil;ağırmak.</p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/11.jpg" alt="" width="951" height="569" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/12.jpg" alt="" width="950" height="235" /></p>
<p><img src="http://yazilimcigunlugu.com/Upload/Content/100/13.jpg" alt="" width="952" height="446" /></p>
<p>Umarım faydalı bir makale olmuştur</p>
<p>Saygılarımla</p>
<p><a href="http://yazilimcigunlugu.com" rel="noopener noreferrer" target="_blank"><span style="font-size: 18px;">http://yazilimcigunlugu.com</span></a></p>

