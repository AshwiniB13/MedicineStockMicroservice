using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockMicroservice.Models
{
    public class MedicineStockTemp
    {
        public string MedicineName { get; set; }
        public string ChemicalComposition { get; set; }
        public string TargetAilment { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public int NumberOfTabletsInStock { get; set; }

        List<MedicineStockTemp> medicineStock = new List<MedicineStockTemp>();
        public MedicineStockTemp(string medicineName, string chemicalComposition, string targetAilMent, DateTime dateOfExpiry,int noOfTabletsInStock)
        {
            MedicineName = medicineName;
            ChemicalComposition = chemicalComposition;
            TargetAilment = targetAilMent;
            DateOfExpiry = dateOfExpiry;
            NumberOfTabletsInStock = noOfTabletsInStock;
        }

        public List<MedicineStockTemp> getMedicine()
        {
            medicineStock.Add(new MedicineStockTemp("aaa", "qwe","ortho", DateTime.Now.AddYears(5), 100));
            medicineStock.Add(new MedicineStockTemp("bbb", "wer", "gynoe", DateTime.Now, 980));
            medicineStock.Add(new MedicineStockTemp("vvv", "rty", "gynoe", DateTime.Now, 370));
            medicineStock.Add(new MedicineStockTemp("ddd", "tgb","gynoe", DateTime.Now, 500));
            medicineStock.Add(new MedicineStockTemp("fff", "ert","general", DateTime.Now, 340));
            return medicineStock;
        }
    }
}
