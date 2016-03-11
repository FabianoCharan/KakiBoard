using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.ApplicationService
{
    public class ApplicationService
    {
        private IUnitOfWork _unitOfWork;

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Commit()
        {
            _unitOfWork.Commit();
            return true;
        }
    }
}
