using Infrastructure.Configuration;

namespace Platform.Contexts;

/// <summary>
/// Configuration manager interface (re-exported from Infrastructure)
/// </summary>
public interface IConfigurationManager : IPlatformConfigurationManager
{
}

/// <summary>
/// Configuration section interface
/// </summary>
public interface IConfigurationSection : IPlatformConfigurationSection
{
}
