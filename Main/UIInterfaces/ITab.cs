using Microsoft.AspNetCore.Components;

namespace Main.UIInterfaces
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}