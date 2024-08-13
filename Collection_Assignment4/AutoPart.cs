using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment4
{
    public class AutoPart
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public List<CarModel> CompatibleCarModels { get; set; }
        public ManufacturingCompany Manufacturer { get; set; }

        public AutoPart(string code, string name, string category, decimal purchasePrice, decimal salePrice, ManufacturingCompany manufacturer)
        {
            Code = code;
            Name = name;
            Category = category;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            CompatibleCarModels = new List<CarModel>();
            Manufacturer = manufacturer;
        }

        public void AddCompatibleCarModel(CarModel carModel)
        {
            CompatibleCarModels.Add(carModel);
        }

        public override string ToString()
        {
            return $"{Name} ({Code}), Category: {Category}, Purchase Price: {PurchasePrice:C}, Sale Price: {SalePrice:C}";
        }
    }

}
