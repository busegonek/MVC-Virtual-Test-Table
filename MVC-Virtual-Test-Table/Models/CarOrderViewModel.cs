using System.ComponentModel;

namespace MVC_Virtual_Test_Table.Models
{
    public class CarOrderViewModel
    {

        //İd olarak post ettiğim alanlar
        [DisplayName("Choose Colour: ")]
        public int ColourId { get; set; }

        [DisplayName("Choose Brand: ")]
        public int BrandId { get; set; }

        [DisplayName("Choose Model: ")]
        public int CarModelId { get; set; }
        
         [DisplayName("Choose Type: ")]
        public int BodyTypeId { get; set; }

        public string OrderNo { get; set; }

        //ilişkiler burda kuruluyor
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Colour> Colours { get; set; }

        public IEnumerable<CarModel> CarModels { get; set; }
        public IEnumerable<BodyType> BodyTypes { get; set; }

    }
}
