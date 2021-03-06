﻿using System;
using Bridge.Html5;
using Bridge.Razor.React.RuntimeSupport;
using Bridge.React;

namespace Bridge.Razor.React
{
    public abstract class RazorComponent<TProps, TState> : Component<TProps, TState> 
    {
        public RazorComponent(TProps props, params Union<ReactElement, string>[] children) : base(props, children)
        {
        }

        protected virtual void RenderRazor(IDomBuilder builder)
        {
            
        }
        
        public override ReactElement Render()
        {
            var builder = new ReactDomBuilder();
            RenderRazor(builder);
            return builder.Create();
        }

        public object Event(Action<SyntheticEvent<HTMLElement>> cb) => cb;
    }
}