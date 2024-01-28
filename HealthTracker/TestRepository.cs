using Dapper;
using HealthTracker.Models;
using System.Data;

namespace HealthTracker
{
    public class TestRepository : ITestRepository
    {
        private readonly IDbConnection _conn;

        public TestRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Test> GetAllTests()
        {
            return _conn.Query<Test>("SELECT * FROM test_results;");
        }

        public Test GetTest(string Date)
        {
            return _conn.QuerySingle<Test>("SELECT * FROM test_results WHERE Date = @Date", new { Date = Date });
        }

        public void UpdateTest(Test updatedTest)
        {
            var query = @"
        UPDATE test_results
        SET CBC_WBC = @CBC_WBC,
            CBC_RBC = @CBC_RBC
        WHERE Number = @Number;";

            _conn.Execute(query, updatedTest);
        }

        public void InsertTest(Test testToInsert)
        {
            _conn.Execute("INSERT INTO test_results (DATE, CBC_WBC, CBC_RBC, CBC_HGB, CBC_HCT, CBC_MCV, CBC_MCH, CBC_MCHC, CBC_RDW_percent, CBC_PLT, CBC_MPV, CBC_Neutrophils_percent, CBC_Lymphocytes_percent, CBC_Lymphocytes_Absolute, CBC_MonocytesAuto_percent, CBC_Monocytes_Absolute, CBC_Eosinophils_percent, CBC_Eosinophils_Absolute, CBC_Basophils_percent, CBC_Basophils_Absolute, CMP_Glucose, CMP_BUN, CMP_Creatinine, CMP_BUN_CreatinineRatio, CMP_Sodium, CMP_Potassium, CMP_Chloride, CMP_CO2, CMP_Calcium, CMP_Protein_Total, CMP_Albumin, CMP_Globulin_Serum_Qn_Calc, CMP_A_G_Ratio, CMP_Bilirubin_Total, CMP_AlkalinePhosphatase, CMP_AST, CMP_ALT, LipidPanel_Cholesterol, LipidPanel_Triglycerides, LipidPanel_HDL, LipidPanel_VLDL, LipidPanel_LDL, LipidPanel_CholesterolHDLRatio, LipidPanel_NonHDLCholesterol, Magnesium, Tacrolimus, Uric_Acid_Serum, Phosphorus_Serum, PTH_Intact, VitaminD, Cystatin_C_w_EstGFR_Serum, Free_T4, HgB_A1C) " +
                "VALUES (@date, @CBC_WBC, @CBC_RBC, @CBC_HGB, @CBC_HCT, @CBC_MCV, @CBC_MCH, @CBC_MCHC, @CBC_RDW_percent, @CBC_PLT, @CBC_MPV, @CBC_Neutrophils_percent, @CBC_Lymphocytes_percent, @CBC_Lymphocytes_Absolute, @CBC_MonocytesAuto_percent, @CBC_Monocytes_Absolute, @CBC_Eosinophils_percent, @CBC_Eosinophils_Absolute, @CBC_Basophils_percent, @CBC_Basophils_Absolute, @CMP_Glucose, @CMP_BUN, @CMP_Creatinine, @CMP_BUN_CreatinineRatio, @CMP_Sodium, @CMP_Potassium, @CMP_Chloride, @CMP_CO2, @CMP_Calcium, @CMP_Protein_Total, @CMP_Albumin, @CMP_Globulin_Serum_Qn_Calc, @CMP_A_G_Ratio, @CMP_Bilirubin_Total, @CMP_AlkalinePhosphatase, @CMP_AST, @CMP_ALT, @LipidPanel_Cholesterol, @LipidPanel_Triglycerides, @LipidPanel_HDL, @LipidPanel_VLDL, @LipidPanel_LDL, @LipidPanel_CholesterolHDLRatio, @LipidPanel_NonHDLCholesterol, @Magnesium, @Tacrolimus, @Uric_Acid_Serum, @Phosphorus_Serum, @PTH_Intact, @VitaminD, @Cystatin_C_w_EstGFR_Serum, @Free_T4, @HgB_A1C );",
                new { date = testToInsert.Date, CBC_WBC = testToInsert.CBC_WBC, CBC_RBC = testToInsert.CBC_RBC, CBC_HGB = testToInsert.CBC_HGB, CBC_HCT=testToInsert.CBC_HCT, CBC_MCV = testToInsert.CBC_MCV, CBC_MCH = testToInsert.CBC_MCH, CBC_MCHC = testToInsert.CBC_MCHC, CBC_RDW_percent = testToInsert.CBC_RDW_percent, CBC_PLT = testToInsert.CBC_PLT, CBC_MPV = testToInsert.CBC_MPV, CBC_Neutrophils_percent = testToInsert.CBC_Neutrophils_percent, CBC_Neutrophils_Absolute = testToInsert.CBC_Neutrophils_Absolute, CBC_Lymphocytes_percent = testToInsert.CBC_Lymphocytes_percent, CBC_Lymphocytes_Absolute = testToInsert.CBC_Lymphocytes_Absolute, CBC_MonocytesAuto_percent = testToInsert.CBC_MonocytesAuto_percent, CBC_Monocytes_Absolute = testToInsert.CBC_Monocytes_Absolute, CBC_Eosinophils_percent = testToInsert.CBC_Eosinophils_percent, CBC_Eosinophils_Absolute = testToInsert.CBC_Eosinophils_Absolute, CBC_Basophils_percent = testToInsert.CBC_Basophils_percent, CBC_Basophils_Absolute = testToInsert.CBC_Basophils_Absolute,
                CMP_Glucose = testToInsert.CMP_Glucose, CMP_BUN = testToInsert.CMP_BUN, CMP_Creatinine = testToInsert.CMP_Creatinine, CMP_BUN_CreatinineRatio = testToInsert.CMP_BUN_CreatinineRatio, CMP_Sodium = testToInsert.CMP_Sodium, CMP_Potassium = testToInsert.CMP_Potassium, CMP_Chloride = testToInsert.CMP_Chloride, CMP_CO2 = testToInsert.CMP_CO2, CMP_Calcium = testToInsert.CMP_Calcium, CMP_Protein_Total = testToInsert.CMP_Protein_Total, CMP_Albumin = testToInsert.CMP_Albumin, CMP_Globulin_Serum_Qn_Calc = testToInsert.CMP_Globulin_Serum_Qn_Calc, CMP_A_G_Ratio = testToInsert.CMP_A_G_Ratio, CMP_Bilirubin_Total = testToInsert.CMP_Bilirubin_Total, CMP_AlkalinePhosphatase = testToInsert.CMP_AlkalinePhosphatase,CMP_AST = testToInsert.CMP_AST, CMP_ALT = testToInsert.CMP_ALT, LipidPanel_Cholesterol = testToInsert.LipidPanel_Cholesterol, LipidPanel_Triglycerides = testToInsert.LipidPanel_Triglycerides, LipidPanel_HDL = testToInsert.LipidPanel_HDL, LipidPanel_VLDL = testToInsert.LipidPanel_VLDL,
                LipidPanel_LDL = testToInsert.LipidPanel_LDL, LipidPanel_CholesterolHDLRatio = testToInsert.LipidPanel_CholesterolHDLRatio, LipidPanel_NonHDLCholesterol = testToInsert.LipidPanel_NonHDLCholesterol, Magnesium = testToInsert.Magnesium, Tacrolimus = testToInsert.Tacrolimus, Uric_Acid_Serum = testToInsert.Uric_Acid_Serum, Phosphorus_Serum = testToInsert.Phosphorus_Serum, PTH_Intact = testToInsert.PTH_Intact, VitaminD = testToInsert.VitaminD, Cystatin_C_w_EstGFR_Serum = testToInsert.Cystatin_C_w_EstGFR_Serum, Free_T4 = testToInsert.FreeT4, HgB_A1C = testToInsert.HgB_A1C });
        }


        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM test_results;");
        }

        public Test AssignCategory()
        {
            var categoryList = GetCategories();
            var test = new Test();
            test.Categories = categoryList;
            return test;
        }
        public void DeleteTest(Test test)
        {
            _conn.Execute("DELETE FROM test_results WHERE Number = @id;", new { id = test.Number });
          
        }

     }
}
