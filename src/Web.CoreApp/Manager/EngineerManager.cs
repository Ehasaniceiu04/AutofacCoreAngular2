using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CoreApp;
using Web.CoreApp.Model;
using Web.CoreApp.Repository;

namespace CoreMVCApp.Manager
{
    class EngineerManager : IEngineerManager
    {
        private readonly IEngineerRepository _engineerRepository;
        private readonly IExperienceRepository _experienceRepository;
        private readonly IUnitOfWork _unitOfWork;
        public EngineerManager(IEngineerRepository engineerRepository,IExperienceRepository experienceRepository, IUnitOfWork unitOfWork)
        {
            _engineerRepository = engineerRepository;
            _experienceRepository = experienceRepository;
            _unitOfWork = unitOfWork;
        }
        void IEngineerManager.Add()
        {
            var engineer = new Engineer
            {
                DateOfBirth = new DateTime(1986,3,1),
                 Name="Ehasanul Hoque",
                 FatherName="Md Shamsur Rahman",
                 MotherName="Nasida Rahman",
            };
            _engineerRepository.Add(engineer);
            var experiences = new List<Experience>()
            {
                new Experience { CompanyName="PixelMask Limited", EngineerId=engineer.Id, StartDate=new DateTime(2011,9,1), EndDate=new DateTime(2014,2,28) },
                new Experience { CompanyName="Orion Informatics Limited",EngineerId=engineer.Id, StartDate=new DateTime(2011,9,1), EndDate=new DateTime(2014,2,28) }
            };
           
            _experienceRepository.AddRange(experiences);
            try
            {
                _unitOfWork.Commit();
            }
            catch(Exception exp)
            {

            }
        }
    }
}
