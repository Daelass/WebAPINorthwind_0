using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPINorthwind_0.RequestModels
{

    //Kullanıcı'nın bir Kategori eklemek için nasıl veri göndereceğinin tasarımı

    public class CategoryCreateRequestModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}