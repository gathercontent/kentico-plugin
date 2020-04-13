﻿namespace GatherContentConnector.GatherContentConnector.IoC
{
    using Microsoft.Practices.ServiceLocation;

    public static class GCServiceLocator
    {
        private static ServiceLocatorProvider currentProvider;

        /// <summary>
        /// The current ambient container.
        ///
        /// </summary>
        public static IServiceLocator Current => currentProvider();

      /// <summary>
        /// Set the delegate that is used to retrieve the current container.
        ///
        /// </summary>
        /// <param name="newProvider">Delegate that, when called, will return
        ///             the current ambient container.</param>
        public static void SetLocatorProvider(ServiceLocatorProvider newProvider)
        {
            currentProvider = newProvider;
        }
    }
}