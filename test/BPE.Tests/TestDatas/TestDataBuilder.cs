using BPE.EntityFrameworkCore;

namespace BPE.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BPEDbContext _context;

        public TestDataBuilder(BPEDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}