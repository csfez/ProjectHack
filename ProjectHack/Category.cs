using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHack
{
    public class Category
    {
        public int Id { get;set; }
        public CategoryNameEnum categoryName { get; set; }
        public List<CategoryNameEnum> GetAllCategoryName()
        {
            List<CategoryNameEnum> ListCatName = Enum.GetValues(typeof(CategoryNameEnum)).Cast<CategoryNameEnum>().ToList();
            return ListCatName;
        }
        public List<string> getAllSubCat(CategoryNameEnum catEnum)
        {
            List<string> listSubCat = new List<string>();
            int id_cat = (int)catEnum;
            if (id_cat == 0) {
                listSubCat = Enum.GetNames(typeof(SubCategoryNameRoadEnum)).ToList();
                return listSubCat; }
            if (id_cat == 1)
            {
                listSubCat = Enum.GetNames(typeof(SubCategoryNameUrbanEnum)).ToList();
                return listSubCat;
            }
            string other = "Other";
            listSubCat.Add(other);
            return listSubCat;

        }
    }
}
