## Startup

### `IConfiguration`

> - 命名空间: `Microsoft.Extensions.Configuration`
> - 程序集: `Microsoft.Extensions.COnfiguration.Abstraction.dll`
> - 派生
>   - [Microsoft.Extensions.Configuration.ConfigurationRoot](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.extensions.configuration.configurationroot?view=dotnet-plat-ext-3.1)
>   - [Microsoft.Extensions.Configuration.ConfigurationSection](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.extensions.configuration.configurationsection?view=dotnet-plat-ext-3.1)
>   - [Microsoft.Extensions.Configuration.IConfigurationRoot](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.extensions.configuration.iconfigurationroot?view=dotnet-plat-ext-3.1)
>   - [Microsoft.Extensions.Configuration.IConfigurationSection](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.extensions.configuration.iconfigurationsection?view=dotnet-plat-ext-3.1)
> - 属性
>   - Item[String] 获取或设置配置值
> - 方法
>   - `GetChildren()`  获取直接后代配置字节.
>   - `GetReloadToken()` 返回一个可用于在重载此配置时进行观察的`IChangeTOken`
>   - `GetSection(String)` 获取具有指定键的配置字节.
> - 扩展方法
>   - `Bind(IConfiguration,Object)` 尝试通过按递归方式根据配置键匹配属性名称, 将给定的对象实例绑定到配置值. 
>   - `Bind(IConfiguration, Object, Action<Binder,Options>)` 尝试通过按递归的方式根据配置键匹配属性名称吗将给定的对象绑定到配置值.
>   - `Bind(IConfiguration, String, Object)` 尝试通过递归的方式根据配置键匹配属性名称, 将给定的对象名称实例绑定到该键指定的配置节.
>   - `Get(IConfiguration,Type)` 尝试将配置实例绑定到类型为T的新实例. 如果此配置节点包含一个值, 则将使用该值, 否则, 通过按递归方式根据配置键匹配属性名称来进行绑定.
>   - `Get(IConfiguration,Type,Action<BinderOptions>)`
>   - `Get<T>(ICongiguration)`
>   - `Get<T>(IConfiguration,Action<BinderOptions>)`
>   - `GetValue(IConfiguration,Type,String,Object)`
>   - `GetValue<T>(IConfiguration,String,T)` 获取指定键的值, 并将其转换为T类型.
>   - `As Enumberable(IConfiguration)` 获取`IConfiguration`中的键值对的枚举
>   - `GetConnectionString(IConfiguration,String)` `GetSection("ConnectionStrings")[name]`的简写形式

### `IConfigurationBuilder`

> - 命名空间: `Microsoft.Extensions.Configuration`
>
> - 程序集: `Microsoft.Extensions.Configuration.Abstractions.dll`
>
> - 派生
>
>   - `Microsoft.Extensions.Configuration.ConfigurationBuilder`
>
> - 属性
>
>   - `Properties` 获取`IConfigurationBuilder` 和已经注册`IConfigurationSource` 之间共享数据的键/值集合.
>   - `Sources` 获取用于获取配置值的源.
>
> - 方法
>
>   - `Add(IConfigurationSource)` 添加一个新的配置源
>
>   - `Build()` 使用在Source中注册一组源中的键和值生成`IConfiguration`.
>
>     



### `IServiceCollection`

> - 命名空间: `Microsoft.Extensions.DependencyInjection`
> - 程序集: `Microsoft.Extension.DependencyInjection.Abstractions.dll`
> - 派生类:
>   - `Microsoft.Extension.DependencyInjection.ServiceCollection`
> - 实现:
>   - `ICollection<ServiceDescriptor>, ICollection<T>, IEnumberable<ServiceDescriptior>, IEnumberable<T>,IList<ServiceDescriptor>,IEnumberable`
> - 扩展方法:
>   - `AddSingleton`
>   - `AddSession`
>   - `AddMemoryCache`
>   - `AddHttpContextAccessor`
>   - `AddMvc`
>   - `AddControllers`
>   - `AddNewtonsoftJson`
>   - `AddAuthentication`
>   - `AddJwtBearer`
>   - ``AddCors``
>   - `AddSwaggerGen`

### `IApplicationBuilder`

### `IWebHostEnvironment`







