using static BlazorEngenharia.Pages.Login;

namespace BlazorEngenharia.Service
{
    public class UsuarioState
    {
        public Usuario Usuario { get; private set; }
        public bool IsLoggedIn => Usuario != null;

        public event Action OnChange;

        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
            NotifyStateChanged();
        }

        public void Logout()
        {
            Usuario = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
