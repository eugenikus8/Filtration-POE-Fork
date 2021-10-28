﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Filtration.ItemFilterPreview.Views;

namespace Filtration.ItemFilterPreview.WindsorInstallers
{
    public class ViewsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IMainWindow>()
                    .ImplementedBy<MainWindow>()
                    .LifeStyle.Singleton);
        }
    }
}
