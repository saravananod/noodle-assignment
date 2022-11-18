using NoodleAssignment.Core.TestRepositories;
using NoodleAssignment.Core.TestServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoodleAssignment.Service
{
    public class TestService : ITestService
    {
        ITestRepository _testRepository;
        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }
        public void Testmethod(string hiTxt)
        {
            _testRepository.Testmethod(hiTxt);
        }
    }
}
