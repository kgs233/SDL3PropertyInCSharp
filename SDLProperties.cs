using SDL;
using static SDL.SDL3;

namespace KGS.SDLWapper;

public class SDLProperties : IDisposable
{
    private bool disposedValue;

    public SDL_PropertiesID SDL_PropertiesID { get; init; } 

    public SDLProperties()
    {
        SDL_PropertiesID = SDL_CreateProperties();
    }

    public void Set<T>(string prop, T value)
    {
        switch (value)
        {
            case string s:
                SDL_SetStringProperty(SDL_PropertiesID, prop, s);
                break;

            case bool b:
                SDL_SetBooleanProperty(SDL_PropertiesID, prop, b);
                break;

            case int i:
                SDL_SetNumberProperty(SDL_PropertiesID, prop, i);
                break;

            case long l:
                SDL_SetNumberProperty(SDL_PropertiesID, prop, l);
                break;

            case float f:
                SDL_SetFloatProperty(SDL_PropertiesID, prop, f);
                break;

            case nint p:
                SDL_SetPointerProperty(SDL_PropertiesID, prop, p);
                break;

            default:
                throw new NotSupportedException(
                    typeof(T).Name
                );
        }
    }


    public T? Get<T>(string prop)
    {
        return typeof(T) switch
        {
            Type t when t == typeof(string) => (T?)(object?)SDL_GetStringProperty(SDL_PropertiesID, prop, default),
            Type t when t == typeof(bool) => (T)(object)SDL_GetBooleanProperty(SDL_PropertiesID, prop, default),
            Type t when t == typeof(long) => (T)(object)SDL_GetNumberProperty(SDL_PropertiesID, prop, default),
            Type t when t == typeof(float) => (T)(object)SDL_GetFloatProperty(SDL_PropertiesID, prop, default),
            Type t when t == typeof(nint) => (T)(object)SDL_GetPointerProperty(SDL_PropertiesID, prop, default),
            _ => throw new NotSupportedException(
                typeof(T).Name
            )
        };
    }

    public void Clear(string name)
    {
        SDL_ClearProperty(SDL_PropertiesID, name);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            SDL_DestroyProperties(SDL_PropertiesID);
            disposedValue = true;
        }
    }

    ~SDLProperties()
    {
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
