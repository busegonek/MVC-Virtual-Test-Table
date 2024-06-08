# MVC Virtual Test Table

Bu proje, ASP.NET Core MVC kullanarak sanal bir araç sipariş tablosu oluşturmayı amaçlar. Kullanıcılar araç markası, modeli, rengi ve gövde tipi seçerek sipariş oluşturabilirler.

## Kullanılan Teknolojiler

- **ASP.NET Core MVC**: Web uygulaması geliştirmek için kullanılan bir framework.
- **C#**: Proje ana dili olarak kullanılmıştır.
- **HTML/CSS**: Kullanıcı arayüzü oluşturmak için kullanılmıştır.
- **Bootstrap**: Sayfa düzeni ve stilleri için kullanılmıştır.
- **Entity Framework Core**: Veritabanı işlemleri için kullanılmıştır.

## Kurulum

1. Bu depoyu klonlayın:

    ```
    git clone https://github.com/busegonek/MVC-Virtual-Test-Table.git
    ```

2. Proje klasörüne gidin:

    ```
    cd MVC-Virtual-Test-Table
    ```

3. Proje dosyalarını Visual Studio veya tercih ettiğiniz bir başka IDE ile açın.

4. Proje dosyalarını derleyin ve çalıştırın.

## Kullanım

1. Ana sayfada, araç markası, modeli, rengi ve gövde tipini seçin.

2. Gerekli alanları doldurun ve "Kaydet" düğmesine basın.

3. Siparişinizin başarıyla alındığına dair bir mesaj alacaksınız.

## Ek Bilgiler

- **Brands.cs**: Araç markalarını temsil eden sınıf.
- **Colour.cs**: Araç renklerini temsil eden sınıf.
- **CarModel.cs**: Araç modellerini temsil eden sınıf.
- **BodyType.cs**: Araç gövde tiplerini temsil eden sınıf.
- **CarOrderController.cs**: MVC kontrolcüsü, araç siparişlerini işlemek için gerekli metotları içerir.
- **CarOrderViewModel.cs**: Araç sipariş formu için görünüm modeli.

## Katkıda Bulunma

- Proje hakkında herhangi bir geribildirim veya sorun mu var? Lütfen [bir sorun açın](https://github.com/busegonek/MVC-Virtual-Test-Table/issues).

- Kodu iyileştirmek veya yeni özellikler eklemek mi istiyorsunuz? Lütfen bir çekme isteği gönderin!

## Lisans

Bu proje [MIT lisansı](LICENSE) altında lisanslanmıştır.
