using System;

namespace AndreyTalanin0x00.Extensions.DependencyInjection;

/// <summary>
/// Encapsulates a method that creates a new instance of the <typeparamref name="TService" /> service type.
/// </summary>
/// <typeparam name="TService">The service type.</typeparam>
/// <typeparam name="TServiceKey">The service key type.</typeparam>
/// <param name="serviceProvider">A <see cref="IServiceProvider" /> instance to resolve other services from.</param>
/// <param name="serviceKey">A <typeparamref name="TServiceKey"/> service key to assign to the service instance.</param>
/// <returns>A new instance of the <typeparamref name="TService" /> service type.</returns>
public delegate TService KeyedServiceImplementationFactory<TService, TServiceKey>(IServiceProvider serviceProvider, TServiceKey? serviceKey);
