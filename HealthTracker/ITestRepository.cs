using HealthTracker.Models;

namespace HealthTracker
{
    public interface ITestRepository
    {
        public IEnumerable<Test> GetAllTests();
        public Test GetTest(int number);

        public void UpdateTest(Test test);
        public void InsertTest(Test testToInsert);
        public IEnumerable<Category> GetCategories();
        public Test AssignCategory();
        public void DeleteTest(Test test);
    }
}
