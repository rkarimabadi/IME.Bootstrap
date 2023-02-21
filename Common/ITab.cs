using Microsoft.AspNetCore.Components;

namespace IME.Bootstrap.Common
{
    public interface ITab
    {
        RenderFragment? ChildContent { get; }
    }
}
