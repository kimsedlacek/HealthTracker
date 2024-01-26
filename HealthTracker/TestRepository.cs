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

        public Test GetTest(int Number)
        {
            return _conn.QuerySingle<Test>("SELECT * FROM test_results WHERE Number = @Number", new { Number = Number});
        }

       
    }
}
