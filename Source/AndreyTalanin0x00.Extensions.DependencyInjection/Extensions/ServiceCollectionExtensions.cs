using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Disable the IDE0001 (Simplify name) notification to preserve explicit service types.
#pragma warning disable IDE0001

// Use the IDE0079 (Remove unnecessary suppression) suppression (a Visual Studio false positive).
// Disable the IDE0130 (Namespace does not match folder structure) notification to preserve namespace structure.
#pragma warning disable IDE0079
#pragma warning disable IDE0130
#pragma warning restore IDE0079

namespace AndreyTalanin0x00.Extensions.DependencyInjection;

/// <summary>
/// Extension methods for adding hosted services to an <see cref="IServiceCollection" />.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add an <see cref="IHostedService" /> registration for the given type.
    /// </summary>
    /// <typeparam name="THostedService">An <see cref="IHostedService" /> to register.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection" /> to register with.</param>
    /// <returns>The original service collection.</returns>
    public static IServiceCollection AddHosted<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] THostedService>(this IServiceCollection services)
        where THostedService : class, IHostedService
    {
        services.AddHostedService<THostedService>();

        return services;
    }

    /// <summary>
    /// Add an <see cref="IHostedService" /> registration for the given type.
    /// </summary>
    /// <typeparam name="THostedService">An <see cref="IHostedService" /> to register.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection" /> to register with.</param>
    /// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
    /// <returns>The original service collection.</returns>
    public static IServiceCollection AddHosted<THostedService>(this IServiceCollection services, ServiceImplementationFactory<THostedService> implementationFactory)
        where THostedService : class, IHostedService
    {
        services.AddHostedService<THostedService>((serviceProvider) => implementationFactory(serviceProvider));

        return services;
    }
}
