using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace jQuerySlideViewASPNET_MVC.Models
{
    public class StudentInformationVm
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodeNo { get; set; }
        public string Address { get; set; }
        [DisplayName("Upload Image")]
        public string ImagePath { get; set; }
        
        public HttpPostedFileBase ImageFile { get; set; }

    }
}