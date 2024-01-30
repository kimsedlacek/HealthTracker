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

        public Test GetTest(int number)
        {
            return _conn.QuerySingle<Test>("SELECT * FROM test_results WHERE number = @number", new { number });
        }

        public void UpdateTest(Test updatedTest)
        {

            _conn.Execute("UPDATE test_results SET Date=@Date, CBC_WBC=@CBC_WBC, CBC_RBC=@CBC_RBC, CBC_HGB=@CBC_HGB, CBC_HCT=@CBC_HCT, CBC_MCV=@CBC_MCV, CBC_MCH=@CBC_MCH, CBC_MCHC=@CBC_MCHC, CBC_RDW_percent=@CBC_RDW_percent, CBC_PLT=@CBC_PLT, CBC_MPV=@CBC_MPV, CBC_Neutrophils_percent=@CBC_Neutrophils_percent, CBC_Neutrophils_Absolute=@CBC_Neutrophils_Absolute, CBC_Lymphocytes_percent=@CBC_Lymphocytes_percent, CBC_Lymphocytes_Absolute=@CBC_Lymphocytes_Absolute, CBC_MonocytesAuto_percent=@CBC_MonocytesAuto_percent, CBC_Monocytes_Absolute=@CBC_Monocytes_Absolute, CBC_Eosinophils_percent=@CBC_Eosinophils_percent, CBC_Eosinophils_Absolute=@CBC_Eosinophils_Absolute, CBC_Basophils_percent=@CBC_Basophils_percent, CBC_Basophils_Absolute=@CBC_Basophils_Absolute, CMP_Glucose=@CMP_Glucose, CMP_BUN=@CMP_BUN, CMP_Creatinine=@CMP_Creatinine, CMP_BUN_CreatinineRatio=@CMP_BUN_CreatinineRatio, CMP_Sodium=@CMP_Sodium, CMP_Potassium=@CMP_Potassium, CMP_Chloride=@CMP_Chloride, CMP_CO2=@CMP_CO2, CMP_Calcium=@CMP_Calcium, CMP_Protein_Total=@CMP_Protein_Total, CMP_Albumin=@CMP_Albumin, CMP_Globulin_Serum_Qn_Calc=@CMP_Globulin_Serum_Qn_Calc, CMP_A_G_Ratio=@CMP_A_G_Ratio, CMP_Bilirubin_Total=@CMP_Bilirubin_Total, CMP_AlkalinePhosphatase=@CMP_AlkalinePhosphatase, CMP_AST=@CMP_AST, CMP_ALT=@CMP_ALT, LipidPanel_Cholesterol=@LipidPanel_Cholesterol, LipidPanel_Triglycerides=@LipidPanel_Triglycerides, LipidPanel_HDL=@LipidPanel_HDL, LipidPanel_VLDL=@LipidPanel_VLDL, LipidPanel_LDL=@LipidPanel_LDL, LipidPanel_CholesterolHDLRatio=@LipidPanel_CholesterolHDLRatio, LipidPanel_NonHDLCholesterol=@LipidPanel_NonHDLCholesterol, Magnesium=@Magnesium, Tacrolimus=@Tacrolimus, Uric_Acid_Serum=@Uric_Acid_Serum, Phosphorus_Serum=@Phosphorus_Serum, PTH_Intact=@PTH_Intact, VitaminD=@VitaminD, Cystatin_C_w_EstGFR_Serum=@Cystatin_C_w_EstGFR_Serum, Free_T4=@Free_T4, TSH=@TSH, HgB_A1C=@HgB_A1C " +
                "WHERE Number = @Number",
                new
            {
                Date = updatedTest.Date,
                CBC_WBC = updatedTest.CBC_WBC,
                CBC_RBC = updatedTest.CBC_RBC,
                CBC_HGB = updatedTest.CBC_HGB,
                CBC_HCT = updatedTest.CBC_HCT,
                CBC_MCV = updatedTest.CBC_MCV,
                CBC_MCH = updatedTest.CBC_MCH,
                CBC_MCHC = updatedTest.CBC_MCHC,
                CBC_RDW_percent = updatedTest.CBC_RDW_percent,
                CBC_PLT = updatedTest.CBC_PLT,
                CBC_MPV = updatedTest.CBC_MPV,
                CBC_Neutrophils_percent = updatedTest.CBC_Neutrophils_percent,
                CBC_Neutrophils_Absolute = updatedTest.CBC_Neutrophils_Absolute,
                CBC_Lymphocytes_percent = updatedTest.CBC_Lymphocytes_percent,
                CBC_Lymphocytes_Absolute = updatedTest.CBC_Lymphocytes_Absolute,
                CBC_MonocytesAuto_percent = updatedTest.CBC_MonocytesAuto_percent,
                CBC_Monocytes_Absolute = updatedTest.CBC_Monocytes_Absolute,
                CBC_Eosinophils_percent = updatedTest.CBC_Eosinophils_percent,
                CBC_Eosinophils_Absolute = updatedTest.CBC_Eosinophils_Absolute,
                CBC_Basophils_percent = updatedTest.CBC_Basophils_percent,
                CBC_Basophils_Absolute = updatedTest.CBC_Basophils_Absolute,
                CMP_Glucose = updatedTest.CMP_Glucose,
                CMP_BUN = updatedTest.CMP_BUN,
                CMP_Creatinine = updatedTest.CMP_Creatinine,
                CMP_BUN_CreatinineRatio = updatedTest.CMP_BUN_CreatinineRatio,
                CMP_Sodium = updatedTest.CMP_Sodium,
                CMP_Potassium = updatedTest.CMP_Potassium,
                CMP_Chloride = updatedTest.CMP_Chloride,
                CMP_CO2 = updatedTest.CMP_CO2,
                CMP_Calcium = updatedTest.CMP_Calcium,
                CMP_Protein_Total = updatedTest.CMP_Protein_Total,
                CMP_Albumin = updatedTest.CMP_Albumin,
                CMP_Globulin_Serum_Qn_Calc = updatedTest.CMP_Globulin_Serum_Qn_Calc,
                CMP_A_G_Ratio = updatedTest.CMP_A_G_Ratio,
                CMP_Bilirubin_Total = updatedTest.CMP_Bilirubin_Total,
                CMP_AlkalinePhosphatase = updatedTest.CMP_AlkalinePhosphatase,
                CMP_AST = updatedTest.CMP_AST,
                CMP_ALT = updatedTest.CMP_ALT,
                LipidPanel_Cholesterol = updatedTest.LipidPanel_Cholesterol,
                LipidPanel_Triglycerides = updatedTest.LipidPanel_Triglycerides,
                LipidPanel_HDL = updatedTest.LipidPanel_HDL,
                LipidPanel_VLDL = updatedTest.LipidPanel_VLDL,
                LipidPanel_LDL = updatedTest.LipidPanel_LDL,
                LipidPanel_CholesterolHDLRatio = updatedTest.LipidPanel_CholesterolHDLRatio,
                LipidPanel_NonHDLCholesterol = updatedTest.LipidPanel_NonHDLCholesterol,
                Magnesium = updatedTest.Magnesium,
                Tacrolimus = updatedTest.Tacrolimus,
                Uric_Acid_Serum = updatedTest.Uric_Acid_Serum,
                Phosphorus_Serum = updatedTest.Phosphorus_Serum,
                PTH_Intact = updatedTest.PTH_Intact,
                VitaminD = updatedTest.VitaminD,
                Cystatin_C_w_EstGFR_Serum = updatedTest.Cystatin_C_w_EstGFR_Serum,
                Free_T4 = updatedTest.Free_T4,
                TSH = updatedTest.TSH,
                HgB_A1C = updatedTest.HgB_A1C,
                Number = updatedTest.Number,
                });
        }
        //var query = @"
        //UPDATE test_results
        //SET CBC_WBC=@CBC_WBC, CBC_RBC=@CBC_RBC, CBC_HGB=@CBC_HGB, CBC_HCT=@CBC_HCT, CBC_MCV=@CBC_MCV, CBC_MCH=@CBC_MCH, CBC_MCHC=@CBC_MCHC, CBC_RDW_percent=CBC_RDW_percent, CBC_PLT=@CBC_PLT, CBC_MPV=@CBC_MPV, CBC_Neutrophils_percent=@CBC_Neutrophils_percent, CBC_Neutrophils_Absolute=@Neutrophils_Absolute, CBC_Lymphocytes_percent=@CBC_Lymphocytes_percent, CBC_Lymphocytes_Absolute=@CBC_Lymphocytes_Absolute, CBC_MonocytesAuto_percent=@CBC_MonocytesAuto_percent, CBC_Monocytes_Absolute=@CBC_Monocytes_Absolute, CBC_Eosinophils_percent=@CBC_Eosinophils_percent, CBC_Eosinophils_Absolute=@CBC_Eosinophils_Absolute, CBC_Basophils_percent=@CBC_Basophils_percent, CBC_Basophils_Absolute=@CBC_Basophils_Absolute, CMP_Glucose=@CMP_Glucose, CMP_BUN=@CMP_BUN, CMP_Creatinine=@CMP_Creatinine, CMP_BUN_CreatinineRatio=@CMP_BUN_CreatinineRatio, CMP_Sodium=@CMP_Sodium, CMP_Potassium=@CMP_Potassium, CMP_Chloride=@CMP_Chloride, CMP_CO2=@CMP_CO2, CMP_Calcium=@CMP_Calcium, CMP_Protein_Total=@CMP_Protein_Total, CMP_Albumin=@CMP_Albumin, CMP_Globulin_Serum_Qn_Calc=@CMP_Globulin_Serum_Qn_Calc, CMP_A_G_Ratio=@CMP_A_G_Ratio, CMP_Bilirubin_Total=@CMP_Bilirubin_Total, CMP_AlkalinePhosphatase=@CMP_AlkalinePhosphatase, CMP_AST=@CMP_AST, CMP_ALT=@CMP_ALT, LipidPanel_Cholesterol=@LipidPanel_Cholesterol, LipidPanel_Triglycerides=@LipidPanel_Triglycerides, LipidPanel_HDL=@LipidPanel_HDL, LipidPanel_VLDL=@LipidPanel_VLDL, LipidPanel_LDL=@LipidPanel_LDL, LipidPanel_CholesterolHDLRatio=@LipidPanel_CholesterolHDLRatio, LipidPanel_NonHDLCholesterol=@LipidPanel_NonHDLCholesterol, Magnesium=@Magnesium, Tacrolimus=@Tacrolimus, Uric_Acid_Serum=@Uric_Acid_Serum, Phosphorus_Serum=@Phosphorus_Serum, PTH_Intact=@PTH_Intact, VitaminD=@VitaminD, Cystatin_C_w_EstGFR_Serum=@Cystatin_C_w_EstGFR, Free_T4=@Free_T4, HgB_A1C=@HgB_A1C

        //WHERE Number = @Number;";

        //_conn.Execute(query, updatedTest);


        public void InsertTest(Test testToInsert)
        {

            _conn.Execute("INSERT INTO test_results (DATE, CBC_WBC, CBC_RBC, CBC_HGB, CBC_HCT, CBC_MCV, CBC_MCH, CBC_MCHC, CBC_RDW_percent, CBC_PLT, CBC_MPV, CBC_Neutrophils_percent, CBC_Neutrophils_Absolute, CBC_Lymphocytes_percent, CBC_Lymphocytes_Absolute, CBC_MonocytesAuto_percent, CBC_Monocytes_Absolute, CBC_Eosinophils_percent, CBC_Eosinophils_Absolute, CBC_Basophils_percent, CBC_Basophils_Absolute, CMP_Glucose, CMP_BUN, CMP_Creatinine, CMP_BUN_CreatinineRatio, CMP_Sodium, CMP_Potassium, CMP_Chloride, CMP_CO2, CMP_Calcium, CMP_Protein_Total, CMP_Albumin, CMP_Globulin_Serum_Qn_Calc, CMP_A_G_Ratio, CMP_Bilirubin_Total, CMP_AlkalinePhosphatase, CMP_AST, CMP_ALT, LipidPanel_Cholesterol, LipidPanel_Triglycerides, LipidPanel_HDL, LipidPanel_VLDL, LipidPanel_LDL, LipidPanel_CholesterolHDLRatio, LipidPanel_NonHDLCholesterol, Magnesium, Tacrolimus, Uric_Acid_Serum, Phosphorus_Serum, PTH_Intact, VitaminD, Cystatin_C_w_EstGFR_Serum, Free_T4, TSH, HgB_A1C) " +
                "VALUES (@date, @CBC_WBC, @CBC_RBC, @CBC_HGB, @CBC_HCT, @CBC_MCV, @CBC_MCH, @CBC_MCHC, @CBC_RDW_percent, @CBC_PLT, @CBC_MPV, @CBC_Neutrophils_percent, @CBC_Neutrophils_Absolute, @CBC_Lymphocytes_percent, @CBC_Lymphocytes_Absolute, @CBC_MonocytesAuto_percent, @CBC_Monocytes_Absolute, @CBC_Eosinophils_percent, @CBC_Eosinophils_Absolute, @CBC_Basophils_percent, @CBC_Basophils_Absolute, @CMP_Glucose, @CMP_BUN, @CMP_Creatinine, @CMP_BUN_CreatinineRatio, @CMP_Sodium, @CMP_Potassium, @CMP_Chloride, @CMP_CO2, @CMP_Calcium, @CMP_Protein_Total, @CMP_Albumin, @CMP_Globulin_Serum_Qn_Calc, @CMP_A_G_Ratio, @CMP_Bilirubin_Total, @CMP_AlkalinePhosphatase, @CMP_AST, @CMP_ALT, @LipidPanel_Cholesterol, @LipidPanel_Triglycerides, @LipidPanel_HDL, @LipidPanel_VLDL, @LipidPanel_LDL, @LipidPanel_CholesterolHDLRatio, @LipidPanel_NonHDLCholesterol, @Magnesium, @Tacrolimus, @Uric_Acid_Serum, @Phosphorus_Serum, @PTH_Intact, @VitaminD, @Cystatin_C_w_EstGFR_Serum, @Free_T4, @TSH, @HgB_A1C );",
                new
                {
                    Date = testToInsert.Date,
                    CBC_WBC = testToInsert.CBC_WBC,
                    CBC_RBC = testToInsert.CBC_RBC,
                    CBC_HGB = testToInsert.CBC_HGB,
                    CBC_HCT = testToInsert.CBC_HCT,
                    CBC_MCV = testToInsert.CBC_MCV,
                    CBC_MCH = testToInsert.CBC_MCH,
                    CBC_MCHC = testToInsert.CBC_MCHC,
                    CBC_RDW_percent = testToInsert.CBC_RDW_percent,
                    CBC_PLT = testToInsert.CBC_PLT,
                    CBC_MPV = testToInsert.CBC_MPV,
                    CBC_Neutrophils_percent = testToInsert.CBC_Neutrophils_percent,
                    CBC_Neutrophils_Absolute = testToInsert.CBC_Neutrophils_Absolute,
                    CBC_Lymphocytes_percent = testToInsert.CBC_Lymphocytes_percent,
                    CBC_Lymphocytes_Absolute = testToInsert.CBC_Lymphocytes_Absolute,
                    CBC_MonocytesAuto_percent = testToInsert.CBC_MonocytesAuto_percent,
                    CBC_Monocytes_Absolute = testToInsert.CBC_Monocytes_Absolute,
                    CBC_Eosinophils_percent = testToInsert.CBC_Eosinophils_percent,
                    CBC_Eosinophils_Absolute = testToInsert.CBC_Eosinophils_Absolute,
                    CBC_Basophils_percent = testToInsert.CBC_Basophils_percent,
                    CBC_Basophils_Absolute = testToInsert.CBC_Basophils_Absolute,
                    CMP_Glucose = testToInsert.CMP_Glucose,
                    CMP_BUN = testToInsert.CMP_BUN,
                    CMP_Creatinine = testToInsert.CMP_Creatinine,
                    CMP_BUN_CreatinineRatio = testToInsert.CMP_BUN_CreatinineRatio,
                    CMP_Sodium = testToInsert.CMP_Sodium,
                    CMP_Potassium = testToInsert.CMP_Potassium,
                    CMP_Chloride = testToInsert.CMP_Chloride,
                    CMP_CO2 = testToInsert.CMP_CO2,
                    CMP_Calcium = testToInsert.CMP_Calcium,
                    CMP_Protein_Total = testToInsert.CMP_Protein_Total,
                    CMP_Albumin = testToInsert.CMP_Albumin,
                    CMP_Globulin_Serum_Qn_Calc = testToInsert.CMP_Globulin_Serum_Qn_Calc,
                    CMP_A_G_Ratio = testToInsert.CMP_A_G_Ratio,
                    CMP_Bilirubin_Total = testToInsert.CMP_Bilirubin_Total,
                    CMP_AlkalinePhosphatase = testToInsert.CMP_AlkalinePhosphatase,
                    CMP_AST = testToInsert.CMP_AST,
                    CMP_ALT = testToInsert.CMP_ALT,
                    LipidPanel_Cholesterol = testToInsert.LipidPanel_Cholesterol,
                    LipidPanel_Triglycerides = testToInsert.LipidPanel_Triglycerides,
                    LipidPanel_HDL = testToInsert.LipidPanel_HDL,
                    LipidPanel_VLDL = testToInsert.LipidPanel_VLDL,
                    LipidPanel_LDL = testToInsert.LipidPanel_LDL,
                    LipidPanel_CholesterolHDLRatio = testToInsert.LipidPanel_CholesterolHDLRatio,
                    LipidPanel_NonHDLCholesterol = testToInsert.LipidPanel_NonHDLCholesterol,
                    Magnesium = testToInsert.Magnesium,
                    Tacrolimus = testToInsert.Tacrolimus,
                    Uric_Acid_Serum = testToInsert.Uric_Acid_Serum,
                    Phosphorus_Serum = testToInsert.Phosphorus_Serum,
                    PTH_Intact = testToInsert.PTH_Intact,
                    VitaminD = testToInsert.VitaminD,
                    Cystatin_C_w_EstGFR_Serum = testToInsert.Cystatin_C_w_EstGFR_Serum,
                    Free_T4 = testToInsert.Free_T4,
                    TSH = testToInsert.TSH,
                    HgB_A1C = testToInsert.HgB_A1C,
                    Number = testToInsert.Number,
                });

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

