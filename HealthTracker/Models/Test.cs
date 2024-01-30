using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Models
{
    public class Test
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double? CBC_WBC { get; set; }
        public double? CBC_RBC { get; set; }
        public double? CBC_HGB { get; set; }
        public double? CBC_HCT { get; set; }
        public double? CBC_MCV { get; set; }
        public double? CBC_MCH { get; set; }
        public double? CBC_MCHC { get; set; }
        public double? CBC_RDW_percent { get; set; }
        public double? CBC_PLT { get; set; }
        public double? CBC_MPV { get; set; }
        public double? CBC_Neutrophils_percent { get; set; }
        public double? CBC_Neutrophils_Absolute { get; set; }
        public double? CBC_Lymphocytes_percent { get; set; }
        public double? CBC_Lymphocytes_Absolute { get; set; }
        public double? CBC_MonocytesAuto_percent { get; set; }
        public double? CBC_Monocytes_Absolute { get; set; }
        public double? CBC_Eosinophils_percent { get; set; }
        public double? CBC_Eosinophils_Absolute { get; set; }
        public double? CBC_Basophils_percent { get; set; }
        public double? CBC_Basophils_Absolute { get; set; }
        public double? CMP_Glucose { get; set; }
        public double? CMP_BUN { get; set; }
        public double? CMP_Creatinine { get; set; }
        public double? CMP_BUN_CreatinineRatio { get; set; }
        public double? CMP_Sodium { get; set; }
        public double? CMP_Potassium { get; set; }
        public double? CMP_Chloride { get; set; }
        public double? CMP_CO2 { get; set; }
        public double? CMP_Calcium { get; set; }
        public double? CMP_Protein_Total { get; set; }
        public double? CMP_Albumin { get; set; }
        public double? CMP_Globulin_Serum_Qn_Calc { get; set; }
        public double? CMP_A_G_Ratio { get; set; }
        public double? CMP_Bilirubin_Total { get; set; }
        public double? CMP_AlkalinePhosphatase { get; set; }
        public double? CMP_AST { get; set; }
        public double? CMP_ALT { get; set; }
        public double? LipidPanel_Cholesterol { get; set; }
        public double? LipidPanel_Triglycerides { get; set; }
        public double? LipidPanel_HDL { get; set; }
        public double? LipidPanel_VLDL { get; set; }
        public double? LipidPanel_LDL { get; set; }
        public double? LipidPanel_CholesterolHDLRatio { get; set; }
        public double? LipidPanel_NonHDLCholesterol { get; set; }
        public double? Magnesium { get; set; }
        public double? Tacrolimus { get; set; }
        public double? Uric_Acid_Serum { get; set; }
        public double? Phosphorus_Serum { get; set; }
        public double? PTH_Intact { get; set; }
        public double? VitaminD { get; set; }
        public double? Cystatin_C_w_EstGFR_Serum { get; set; }
        public double? Free_T4 { get; set; }
        public double? TSH { get; set; }
        public double? HgB_A1C { get; set; }
        public IEnumerable<Category>? Categories { get; set; }
        //public string? DisplayLine(int? value)

        //{
        //    if (value == null || value == 0)
        //    {
        //        return "---";
        //    }
        //    else
        //    {
        //        return value.ToString();
        //    }

        //}
    }
}
        



