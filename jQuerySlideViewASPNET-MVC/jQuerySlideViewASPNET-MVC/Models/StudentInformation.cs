using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Web.Mvc;

namespace jQuerySlideViewASPNET_MVC.Models
{
    public class StudentInformation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodeNo { get; set; }
        public string Address { get; set; }
        [DisplayName("Upload Image")]
        public string ImagePath { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

 
    }
}