using ContactManagement.Application.Interfaces.Presenters;

namespace ContactManagement.Application.Interfaces.Views
{
    public interface IMainView
    {
        void SetPresenter(IMainPresenter presenter);
        void Show(); 
        void ShowError(string message);
    }
}
