using ReadyGamerOne.View;
using Moba.Const;
namespace Moba.View
{
	public partial class LoginPanel : AbstractPanel
	{
		partial void OnLoad();

		protected override void Load()
		{
			Create(PanelName.LoginPanel);
			OnLoad();
		}
	}
}
