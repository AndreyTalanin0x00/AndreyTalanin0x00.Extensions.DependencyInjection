using System;

namespace AndreyTalanin0x00.Extensions.DependencyInjection;

/// <summary>
/// Encapsulates a method that creates a new instance of the <typeparamref name="TService" /> service type.
/// </summary>
/// <typeparam name="TService">The service type.</typeparam>
/// <param name="serviceProvider">A <see cref="IServiceProvider" /> instance to resolve other services from.</param>
/// <returns>A new instance of the <typeparamref name="TService" /> service type.</returns>
public delegate TService ServiceImplementationFactory<TService>(IServiceProvider serviceProvider);
