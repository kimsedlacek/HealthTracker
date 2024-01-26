using HealthTracker.Models;

namespace HealthTracker
{
    public interface ITestRepository
    {
        public IEnumerable<Test> GetAllTests();
        public Test GetTest(int Number);

    }
}
