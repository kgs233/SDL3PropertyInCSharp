namespace MyBrain.SDLWapper;

public static class SDLProperty
{
    private const string pre = "SDL.";

    public static class Audiostream
    {
        private const string pre = SDLProperty.pre + "audiostream.";

        public static class Auto
        {
            private const string pre = Audiostream.pre + "auto.";

            public const string Auto_cleanup = pre + "auto_cleanup";
        }

    }
    public static class File
    {
        private const string pre = SDLProperty.pre + "file.";

        public static class Dialog
        {
            private const string pre = File.pre + "dialog.";

            public const string Filters = pre + "filters";
            public const string Nfilters = pre + "nfilters";
            public const string Window = pre + "window";
            public const string Location = pre + "location";
            public const string Many = pre + "many";
            public const string Title = pre + "title";
            public const string Accept = pre + "accept";
            public const string Cancel = pre + "cancel";
        }

    }
    public static class Gamepad
    {
        private const string pre = SDLProperty.pre + "gamepad.";

        public static class Cap
        {
            private const string pre = Gamepad.pre + "cap.";

            public const string Rumble = pre + "rumble";

            public static class Mono
            {
                private const string pre = Cap.pre + "mono.";

                public const string Mono_led = pre + "mono_led";
            }

            public static class Rgb
            {
                private const string pre = Cap.pre + "rgb.";

                public const string Rgb_led = pre + "rgb_led";
            }

            public static class Player
            {
                private const string pre = Cap.pre + "player.";

                public const string Player_led = pre + "player_led";
            }

            public static class Trigger
            {
                private const string pre = Cap.pre + "trigger.";

                public const string Trigger_rumble = pre + "trigger_rumble";
            }

        }

    }
    public static class Gpu
    {
        private const string pre = SDLProperty.pre + "gpu.";

        public static class Device
        {
            private const string pre = Gpu.pre + "device.";

            public const string Name = pre + "name";

            public static class Create
            {
                private const string pre = Device.pre + "create.";

                public const string Debugmode = pre + "debugmode";
                public const string Preferlowpower = pre + "preferlowpower";
                public const string Verbose = pre + "verbose";
                public const string Name = pre + "name";

                public static class Feature
                {
                    private const string pre = Create.pre + "feature.";

                    public const string Anisotropy = pre + "anisotropy";

                    public static class Clip
                    {
                        private const string pre = Feature.pre + "clip.";

                        public const string Clip_distance = pre + "clip_distance";
                    }

                    public static class Depth
                    {
                        private const string pre = Feature.pre + "depth.";

                        public const string Depth_clamping = pre + "depth_clamping";
                    }

                    public static class Indirect
                    {
                        private const string pre = Feature.pre + "indirect.";

                        public static class Draw
                        {
                            private const string pre = Indirect.pre + "draw.";

                            public static class First
                            {
                                private const string pre = Draw.pre + "first.";

                                public const string Indirect_draw_first_instance = pre + "indirect_draw_first_instance";
                            }

                        }

                    }

                }

                public static class Shaders
                {
                    private const string pre = Create.pre + "shaders.";

                    public const string Private = pre + "private";
                    public const string Spirv = pre + "spirv";
                    public const string Dxbc = pre + "dxbc";
                    public const string Dxil = pre + "dxil";
                    public const string Msl = pre + "msl";
                    public const string Metallib = pre + "metallib";
                }

                public static class D3d12
                {
                    private const string pre = Create.pre + "d3d12.";

                    public static class Allow
                    {
                        private const string pre = D3d12.pre + "allow.";

                        public static class Fewer
                        {
                            private const string pre = Allow.pre + "fewer.";

                            public static class Resource
                            {
                                private const string pre = Fewer.pre + "resource.";

                                public const string Allowtier1resourcebinding = pre + "allowtier1resourcebinding";
                            }

                        }

                    }

                    public const string Semantic = pre + "semantic";

                    public static class Agility
                    {
                        private const string pre = D3d12.pre + "agility.";

                        public static class Sdk
                        {
                            private const string pre = Agility.pre + "sdk.";

                            public const string Agility_sdk_version = pre + "agility_sdk_version";
                            public const string Agility_sdk_path = pre + "agility_sdk_path";
                        }

                    }

                }

                public static class Vulkan
                {
                    private const string pre = Create.pre + "vulkan.";

                    public const string Options = pre + "options";

                    public static class Require
                    {
                        private const string pre = Vulkan.pre + "require.";

                        public static class Hardware
                        {
                            private const string pre = Require.pre + "hardware.";

                            public const string Requirehardwareacceleration = pre + "requirehardwareacceleration";
                        }

                    }

                }

                public static class Metal
                {
                    private const string pre = Create.pre + "metal.";

                    public static class Allow
                    {
                        private const string pre = Metal.pre + "allow.";

                        public const string Allowmacfamily1 = pre + "allowmacfamily1";
                    }

                }

                public static class Xr
                {
                    private const string pre = Create.pre + "xr.";

                    public const string Enable = pre + "enable";
                    public const string Instance_out = pre + "instance_out";
                    public const string Version = pre + "version";

                    public static class System
                    {
                        private const string pre = Xr.pre + "system.";

                        public const string System_id_out = pre + "system_id_out";
                    }

                    public static class Form
                    {
                        private const string pre = Xr.pre + "form.";

                        public const string Form_factor = pre + "form_factor";
                    }

                    public static class Extension
                    {
                        private const string pre = Xr.pre + "extension.";

                        public const string Count = pre + "count";
                        public const string Names = pre + "names";
                    }

                    public static class Layer
                    {
                        private const string pre = Xr.pre + "layer.";

                        public const string Count = pre + "count";
                        public const string Names = pre + "names";
                    }

                    public static class Application
                    {
                        private const string pre = Xr.pre + "application.";

                        public const string Name = pre + "name";
                        public const string Version = pre + "version";
                    }

                    public static class Engine
                    {
                        private const string pre = Xr.pre + "engine.";

                        public const string Name = pre + "name";
                        public const string Version = pre + "version";
                    }

                }

            }

            public static class Driver
            {
                private const string pre = Device.pre + "driver.";

                public const string Driver_name = pre + "driver_name";
                public const string Driver_version = pre + "driver_version";
                public const string Driver_info = pre + "driver_info";
            }

        }

        public static class Computepipeline
        {
            private const string pre = Gpu.pre + "computepipeline.";

            public static class Create
            {
                private const string pre = Computepipeline.pre + "create.";

                public const string Name = pre + "name";
            }

        }

        public static class Graphicspipeline
        {
            private const string pre = Gpu.pre + "graphicspipeline.";

            public static class Create
            {
                private const string pre = Graphicspipeline.pre + "create.";

                public const string Name = pre + "name";
            }

        }

        public static class Sampler
        {
            private const string pre = Gpu.pre + "sampler.";

            public static class Create
            {
                private const string pre = Sampler.pre + "create.";

                public const string Name = pre + "name";
            }

        }

        public static class Shader
        {
            private const string pre = Gpu.pre + "shader.";

            public static class Create
            {
                private const string pre = Shader.pre + "create.";

                public const string Name = pre + "name";
            }

        }

        public static class Texture
        {
            private const string pre = Gpu.pre + "texture.";

            public static class Create
            {
                private const string pre = Texture.pre + "create.";

                public const string Name = pre + "name";

                public static class D3d12
                {
                    private const string pre = Create.pre + "d3d12.";

                    public static class Clear
                    {
                        private const string pre = D3d12.pre + "clear.";

                        public const string R = pre + "r";
                        public const string G = pre + "g";
                        public const string B = pre + "b";
                        public const string A = pre + "a";
                        public const string Depth = pre + "depth";
                        public const string Stencil = pre + "stencil";
                    }

                }

            }

        }

        public static class Buffer
        {
            private const string pre = Gpu.pre + "buffer.";

            public static class Create
            {
                private const string pre = Buffer.pre + "create.";

                public const string Name = pre + "name";
            }

        }

        public static class Transferbuffer
        {
            private const string pre = Gpu.pre + "transferbuffer.";

            public static class Create
            {
                private const string pre = Transferbuffer.pre + "create.";

                public const string Name = pre + "name";
            }

        }

    }
    public static class Hidapi
    {
        private const string pre = SDLProperty.pre + "hidapi.";

        public static class Libusb
        {
            private const string pre = Hidapi.pre + "libusb.";

            public static class Device
            {
                private const string pre = Libusb.pre + "device.";

                public const string Handle = pre + "handle";
            }

        }

    }
    public static class App
    {
        private const string pre = SDLProperty.pre + "app.";

        public static class Metadata
        {
            private const string pre = App.pre + "metadata.";

            public const string Name = pre + "name";
            public const string Version = pre + "version";
            public const string Identifier = pre + "identifier";
            public const string Creator = pre + "creator";
            public const string Copyright = pre + "copyright";
            public const string Url = pre + "url";
            public const string Type = pre + "type";
        }

    }
    public static class Iostream
    {
        private const string pre = SDLProperty.pre + "iostream.";

        public const string Base = pre + "base";

        public static class Windows
        {
            private const string pre = Iostream.pre + "windows.";

            public const string Handle = pre + "handle";
        }

        public static class Stdio
        {
            private const string pre = Iostream.pre + "stdio.";

            public const string File = pre + "file";
        }

        public static class File
        {
            private const string pre = Iostream.pre + "file.";

            public const string File_descriptor = pre + "file_descriptor";
        }

        public static class Android
        {
            private const string pre = Iostream.pre + "android.";

            public const string Aasset = pre + "aasset";
        }

        public static class Memory
        {
            private const string pre = Iostream.pre + "memory.";

            public const string Size = pre + "size";
            public const string Free = pre + "free";
        }

        public static class Dynamic
        {
            private const string pre = Iostream.pre + "dynamic.";

            public const string Memory = pre + "memory";
            public const string Chunksize = pre + "chunksize";
        }

    }
    public static class Joystick
    {
        private const string pre = SDLProperty.pre + "joystick.";

        public static class Cap
        {
            private const string pre = Joystick.pre + "cap.";

            public const string Rumble = pre + "rumble";

            public static class Mono
            {
                private const string pre = Cap.pre + "mono.";

                public const string Mono_led = pre + "mono_led";
            }

            public static class Rgb
            {
                private const string pre = Cap.pre + "rgb.";

                public const string Rgb_led = pre + "rgb_led";
            }

            public static class Player
            {
                private const string pre = Cap.pre + "player.";

                public const string Player_led = pre + "player_led";
            }

            public static class Trigger
            {
                private const string pre = Cap.pre + "trigger.";

                public const string Trigger_rumble = pre + "trigger_rumble";
            }

        }

    }
    public static class Textinput
    {
        private const string pre = SDLProperty.pre + "textinput.";

        public const string Type = pre + "type";
        public const string Capitalization = pre + "capitalization";
        public const string Autocorrect = pre + "autocorrect";
        public const string Multiline = pre + "multiline";
        public const string Title = pre + "title";
        public const string Placeholder = pre + "placeholder";

        public static class Default
        {
            private const string pre = Textinput.pre + "default.";

            public const string Default_text = pre + "default_text";
        }

        public static class Max
        {
            private const string pre = Textinput.pre + "max.";

            public const string Max_length = pre + "max_length";
        }

        public static class Android
        {
            private const string pre = Textinput.pre + "android.";

            public const string Inputtype = pre + "inputtype";
        }

    }
    public static class Process
    {
        private const string pre = SDLProperty.pre + "process.";

        public const string Pid = pre + "pid";
        public const string Stdin = pre + "stdin";
        public const string Stdout = pre + "stdout";
        public const string Stderr = pre + "stderr";
        public const string Background = pre + "background";

        public static class Create
        {
            private const string pre = Process.pre + "create.";

            public const string Args = pre + "args";
            public const string Environment = pre + "environment";
            public const string Stdin_option = pre + "stdin_option";
            public const string Stdin_source = pre + "stdin_source";
            public const string Stdout_option = pre + "stdout_option";
            public const string Stdout_source = pre + "stdout_source";
            public const string Stderr_option = pre + "stderr_option";
            public const string Stderr_source = pre + "stderr_source";
            public const string Background = pre + "background";
            public const string Cmdline = pre + "cmdline";

            public static class Working
            {
                private const string pre = Create.pre + "working.";

                public const string Working_directory = pre + "working_directory";
            }

            public static class Stderr
            {
                private const string pre = Create.pre + "stderr.";

                public static class To
                {
                    private const string pre = Stderr.pre + "to.";

                    public const string Stderr_to_stdout = pre + "stderr_to_stdout";
                }

            }

        }

    }
    public static class Renderer
    {
        private const string pre = SDLProperty.pre + "renderer.";

        public const string Name = pre + "name";
        public const string Window = pre + "window";
        public const string Surface = pre + "surface";
        public const string Vsync = pre + "vsync";

        public static class Create
        {
            private const string pre = Renderer.pre + "create.";

            public const string Name = pre + "name";
            public const string Window = pre + "window";
            public const string Surface = pre + "surface";

            public static class Output
            {
                private const string pre = Create.pre + "output.";

                public const string Output_colorspace = pre + "output_colorspace";
            }

            public static class Present
            {
                private const string pre = Create.pre + "present.";

                public const string Present_vsync = pre + "present_vsync";
            }

            public static class Gpu
            {
                private const string pre = Create.pre + "gpu.";

                public const string Device = pre + "device";

                public static class Shaders
                {
                    private const string pre = Gpu.pre + "shaders.";

                    public const string Shaders_spirv = pre + "shaders_spirv";
                    public const string Shaders_dxil = pre + "shaders_dxil";
                    public const string Shaders_msl = pre + "shaders_msl";
                }

            }

            public static class Vulkan
            {
                private const string pre = Create.pre + "vulkan.";

                public const string Instance = pre + "instance";
                public const string Surface = pre + "surface";
                public const string Device = pre + "device";

                public static class Physical
                {
                    private const string pre = Vulkan.pre + "physical.";

                    public const string Physical_device = pre + "physical_device";
                }

                public static class Graphics
                {
                    private const string pre = Vulkan.pre + "graphics.";

                    public static class Queue
                    {
                        private const string pre = Graphics.pre + "queue.";

                        public static class Family
                        {
                            private const string pre = Queue.pre + "family.";

                            public const string Graphics_queue_family_index = pre + "graphics_queue_family_index";
                        }

                    }

                }

                public static class Present
                {
                    private const string pre = Vulkan.pre + "present.";

                    public static class Queue
                    {
                        private const string pre = Present.pre + "queue.";

                        public static class Family
                        {
                            private const string pre = Queue.pre + "family.";

                            public const string Present_queue_family_index = pre + "present_queue_family_index";
                        }

                    }

                }

            }

        }

        public static class Max
        {
            private const string pre = Renderer.pre + "max.";

            public static class Texture
            {
                private const string pre = Max.pre + "texture.";

                public const string Max_texture_size = pre + "max_texture_size";
            }

        }

        public static class Texture
        {
            private const string pre = Renderer.pre + "texture.";

            public const string Texture_formats = pre + "texture_formats";
            public const string Texture_wrapping = pre + "texture_wrapping";
        }

        public static class Output
        {
            private const string pre = Renderer.pre + "output.";

            public const string Output_colorspace = pre + "output_colorspace";
        }

        public static class Hdr
        {
            private const string pre = Renderer.pre + "hdr.";

            public const string Hdr_enabled = pre + "HDR_enabled";
            public const string Hdr_headroom = pre + "HDR_headroom";
        }

        public static class Sdr
        {
            private const string pre = Renderer.pre + "sdr.";

            public static class White
            {
                private const string pre = Sdr.pre + "white.";

                public const string Sdr_white_point = pre + "SDR_white_point";
            }

        }

        public static class D3d9
        {
            private const string pre = Renderer.pre + "d3d9.";

            public const string Device = pre + "device";
        }

        public static class D3d11
        {
            private const string pre = Renderer.pre + "d3d11.";

            public const string Device = pre + "device";
            public const string Swap_chain = pre + "swap_chain";
        }

        public static class D3d12
        {
            private const string pre = Renderer.pre + "d3d12.";

            public const string Device = pre + "device";
            public const string Swap_chain = pre + "swap_chain";

            public static class Command
            {
                private const string pre = D3d12.pre + "command.";

                public const string Command_queue = pre + "command_queue";
            }

        }

        public static class Vulkan
        {
            private const string pre = Renderer.pre + "vulkan.";

            public const string Instance = pre + "instance";
            public const string Surface = pre + "surface";
            public const string Device = pre + "device";

            public static class Physical
            {
                private const string pre = Vulkan.pre + "physical.";

                public const string Physical_device = pre + "physical_device";
            }

            public static class Graphics
            {
                private const string pre = Vulkan.pre + "graphics.";

                public static class Queue
                {
                    private const string pre = Graphics.pre + "queue.";

                    public static class Family
                    {
                        private const string pre = Queue.pre + "family.";

                        public const string Graphics_queue_family_index = pre + "graphics_queue_family_index";
                    }

                }

            }

            public static class Present
            {
                private const string pre = Vulkan.pre + "present.";

                public static class Queue
                {
                    private const string pre = Present.pre + "queue.";

                    public static class Family
                    {
                        private const string pre = Queue.pre + "family.";

                        public const string Present_queue_family_index = pre + "present_queue_family_index";
                    }

                }

            }

            public static class Swapchain
            {
                private const string pre = Vulkan.pre + "swapchain.";

                public static class Image
                {
                    private const string pre = Swapchain.pre + "image.";

                    public const string Swapchain_image_count = pre + "swapchain_image_count";
                }

            }

        }

        public static class Gpu
        {
            private const string pre = Renderer.pre + "gpu.";

            public const string Device = pre + "device";
        }

    }
    public static class Texture
    {
        private const string pre = SDLProperty.pre + "texture.";

        public const string Colorspace = pre + "colorspace";
        public const string Format = pre + "format";
        public const string Access = pre + "access";
        public const string Width = pre + "width";
        public const string Height = pre + "height";

        public static class Create
        {
            private const string pre = Texture.pre + "create.";

            public const string Colorspace = pre + "colorspace";
            public const string Format = pre + "format";
            public const string Access = pre + "access";
            public const string Width = pre + "width";
            public const string Height = pre + "height";
            public const string Palette = pre + "palette";

            public static class Sdr
            {
                private const string pre = Create.pre + "sdr.";

                public static class White
                {
                    private const string pre = Sdr.pre + "white.";

                    public const string Sdr_white_point = pre + "SDR_white_point";
                }

            }

            public static class Hdr
            {
                private const string pre = Create.pre + "hdr.";

                public const string Hdr_headroom = pre + "HDR_headroom";
            }

            public static class D3d11
            {
                private const string pre = Create.pre + "d3d11.";

                public static class Texture
                {
                    private const string pre = D3d11.pre + "texture.";

                    public const string Texture_u = pre + "texture_u";
                    public const string Texture_v = pre + "texture_v";
                }

            }

            public static class D3d12
            {
                private const string pre = Create.pre + "d3d12.";

                public static class Texture
                {
                    private const string pre = D3d12.pre + "texture.";

                    public const string Texture_u = pre + "texture_u";
                    public const string Texture_v = pre + "texture_v";
                }

            }

            public static class Metal
            {
                private const string pre = Create.pre + "metal.";

                public const string Pixelbuffer = pre + "pixelbuffer";
            }

            public static class Opengl
            {
                private const string pre = Create.pre + "opengl.";

                public static class Texture
                {
                    private const string pre = Opengl.pre + "texture.";

                    public const string Texture_uv = pre + "texture_uv";
                    public const string Texture_u = pre + "texture_u";
                    public const string Texture_v = pre + "texture_v";
                }

            }

            public static class Opengles2
            {
                private const string pre = Create.pre + "opengles2.";

                public static class Texture
                {
                    private const string pre = Opengles2.pre + "texture.";

                    public const string Texture_uv = pre + "texture_uv";
                    public const string Texture_u = pre + "texture_u";
                    public const string Texture_v = pre + "texture_v";
                }

            }

            public static class Vulkan
            {
                private const string pre = Create.pre + "vulkan.";

                public const string Texture = pre + "texture";
                public const string Layout = pre + "layout";
            }

            public static class Gpu
            {
                private const string pre = Create.pre + "gpu.";

                public static class Texture
                {
                    private const string pre = Gpu.pre + "texture.";

                    public const string Texture_uv = pre + "texture_uv";
                    public const string Texture_u = pre + "texture_u";
                    public const string Texture_v = pre + "texture_v";
                }

            }

        }

        public static class Sdr
        {
            private const string pre = Texture.pre + "sdr.";

            public static class White
            {
                private const string pre = Sdr.pre + "white.";

                public const string Sdr_white_point = pre + "SDR_white_point";
            }

        }

        public static class Hdr
        {
            private const string pre = Texture.pre + "hdr.";

            public const string Hdr_headroom = pre + "HDR_headroom";
        }

        public static class D3d11
        {
            private const string pre = Texture.pre + "d3d11.";

            public static class Texture_
            {
                private const string pre = D3d11.pre + "texture.";

                public const string Texture_u = pre + "texture_u";
                public const string Texture_v = pre + "texture_v";
            }

        }

        public static class D3d12
        {
            private const string pre = Texture.pre + "d3d12.";

            public static class Texture_
            {
                private const string pre = D3d12.pre + "texture.";

                public const string Texture_u = pre + "texture_u";
                public const string Texture_v = pre + "texture_v";
            }

        }

        public static class Opengl
        {
            private const string pre = Texture.pre + "opengl.";

            public static class Texture_
            {
                private const string pre = Opengl.pre + "texture.";

                public const string Texture_uv = pre + "texture_uv";
                public const string Texture_u = pre + "texture_u";
                public const string Texture_v = pre + "texture_v";
                public const string Target = pre + "target";
            }

            public static class Tex
            {
                private const string pre = Opengl.pre + "tex.";

                public const string Tex_w = pre + "tex_w";
                public const string Tex_h = pre + "tex_h";
            }

        }

        public static class Opengles2
        {
            private const string pre = Texture.pre + "opengles2.";

            public static class Texture_
            {
                private const string pre = Opengles2.pre + "texture.";

                public const string Texture_uv = pre + "texture_uv";
                public const string Texture_u = pre + "texture_u";
                public const string Texture_v = pre + "texture_v";
                public const string Target = pre + "target";
            }

        }

        public static class Vulkan
        {
            private const string pre = Texture.pre + "vulkan.";
        }

        public static class Gpu
        {
            private const string pre = Texture.pre + "gpu.";

            public static class Texture_
            {
                private const string pre = Gpu.pre + "texture.";

                public const string Texture_uv = pre + "texture_uv";
                public const string Texture_u = pre + "texture_u";
                public const string Texture_v = pre + "texture_v";
            }

        }

    }
    public static class Surface
    {
        private const string pre = SDLProperty.pre + "surface.";

        public const string Rotation = pre + "rotation";

        public static class Sdr
        {
            private const string pre = Surface.pre + "sdr.";

            public static class White
            {
                private const string pre = Sdr.pre + "white.";

                public const string Sdr_white_point = pre + "SDR_white_point";
            }

        }

        public static class Hdr
        {
            private const string pre = Surface.pre + "hdr.";

            public const string Hdr_headroom = pre + "HDR_headroom";
        }

        public const string Tonemap = pre + "tonemap";

        public static class Hotspot
        {
            private const string pre = Surface.pre + "hotspot.";

            public const string X = pre + "x";
            public const string Y = pre + "y";
        }

    }
    public static class Global
    {
        private const string pre = SDLProperty.pre + "global.";

        public static class System
        {
            private const string pre = Global.pre + "system.";

            public static class Ubuntu
            {
                private const string pre = System.pre + "ubuntu.";

                public static class Touch
                {
                    private const string pre = Ubuntu.pre + "touch.";

                    public const string Appid = pre + "appid";
                    public const string Hook = pre + "hook";

                    public static class App
                    {
                        private const string pre = Touch.pre + "app.";

                        public const string App_version = pre + "app_version";
                    }

                }

            }

        }

        public static class Video
        {
            private const string pre = Global.pre + "video.";

            public static class Wayland
            {
                private const string pre = Video.pre + "wayland.";

                public static class Wl
                {
                    private const string pre = Wayland.pre + "wl.";

                    public const string Wl_display = pre + "wl_display";
                }

            }

        }

    }
    public static class Thread
    {
        private const string pre = SDLProperty.pre + "thread.";

        public static class Create
        {
            private const string pre = Thread.pre + "create.";

            public const string Name = pre + "name";
            public const string Userdata = pre + "userdata";
            public const string Stacksize = pre + "stacksize";

            public static class Entry
            {
                private const string pre = Create.pre + "entry.";

                public const string Entry_function = pre + "entry_function";
            }

        }

    }
    public static class Tray
    {
        private const string pre = SDLProperty.pre + "tray.";

        public static class Create
        {
            private const string pre = Tray.pre + "create.";

            public const string Icon = pre + "icon";
            public const string Tooltip = pre + "tooltip";
            public const string Userdata = pre + "userdata";

            public static class Leftclick
            {
                private const string pre = Create.pre + "leftclick.";

                public const string Leftclick_callback = pre + "leftclick_callback";
            }

            public static class Rightclick
            {
                private const string pre = Create.pre + "rightclick.";

                public const string Rightclick_callback = pre + "rightclick_callback";
            }

            public static class Middleclick
            {
                private const string pre = Create.pre + "middleclick.";

                public const string Middleclick_callback = pre + "middleclick_callback";
            }

        }

    }
    public static class Display
    {
        private const string pre = SDLProperty.pre + "display.";

        public static class Hdr
        {
            private const string pre = Display.pre + "hdr.";

            public const string Hdr_enabled = pre + "HDR_enabled";
        }

        public static class Kmsdrm
        {
            private const string pre = Display.pre + "kmsdrm.";

            public static class Panel
            {
                private const string pre = Kmsdrm.pre + "panel.";

                public const string Panel_orientation = pre + "panel_orientation";
            }

        }

        public static class Wayland
        {
            private const string pre = Display.pre + "wayland.";

            public static class Wl
            {
                private const string pre = Wayland.pre + "wl.";

                public const string Wl_output = pre + "wl_output";
            }

        }

        public static class Windows
        {
            private const string pre = Display.pre + "windows.";

            public const string Hmonitor = pre + "hmonitor";
        }

    }
    public static class Window
    {
        private const string pre = SDLProperty.pre + "window.";

        public const string Shape = pre + "shape";

        public static class Create
        {
            private const string pre = Window.pre + "create.";

            public const string Borderless = pre + "borderless";
            public const string Focusable = pre + "focusable";
            public const string Flags = pre + "flags";
            public const string Fullscreen = pre + "fullscreen";
            public const string Height = pre + "height";
            public const string Hidden = pre + "hidden";
            public const string Maximized = pre + "maximized";
            public const string Menu = pre + "menu";
            public const string Metal = pre + "metal";
            public const string Minimized = pre + "minimized";
            public const string Modal = pre + "modal";
            public const string Opengl = pre + "opengl";
            public const string Parent = pre + "parent";
            public const string Resizable = pre + "resizable";
            public const string Title = pre + "title";
            public const string Transparent = pre + "transparent";
            public const string Tooltip = pre + "tooltip";
            public const string Utility = pre + "utility";
            public const string Vulkan = pre + "vulkan";
            public const string Width = pre + "width";
            public const string X = pre + "x";
            public const string Y = pre + "y";
            public const string Windowscene = pre + "windowscene";

            public static class Always
            {
                private const string pre = Create.pre + "always.";

                public static class On
                {
                    private const string pre = Always.pre + "on.";

                    public const string Always_on_top = pre + "always_on_top";
                }

            }

            public static class Constrain
            {
                private const string pre = Create.pre + "constrain.";

                public const string Constrain_popup = pre + "constrain_popup";
            }

            public static class External
            {
                private const string pre = Create.pre + "external.";

                public static class Graphics
                {
                    private const string pre = External.pre + "graphics.";

                    public const string External_graphics_context = pre + "external_graphics_context";
                }

            }

            public static class High
            {
                private const string pre = Create.pre + "high.";

                public static class Pixel
                {
                    private const string pre = High.pre + "pixel.";

                    public const string High_pixel_density = pre + "high_pixel_density";
                }

            }

            public static class Mouse
            {
                private const string pre = Create.pre + "mouse.";

                public const string Mouse_grabbed = pre + "mouse_grabbed";
            }

            public static class Cocoa
            {
                private const string pre = Create.pre + "cocoa.";

                public const string Window = pre + "window";
                public const string View = pre + "view";
            }

            public static class Wayland
            {
                private const string pre = Create.pre + "wayland.";

                public static class Surface
                {
                    private const string pre = Wayland.pre + "surface.";

                    public static class Role
                    {
                        private const string pre = Surface.pre + "role.";

                        public const string Surface_role_custom = pre + "surface_role_custom";
                    }

                }

                public static class Create_
                {
                    private const string pre = Wayland.pre + "create.";

                    public static class Egl
                    {
                        private const string pre = Create.pre + "egl.";

                        public const string Create_egl_window = pre + "create_egl_window";
                    }

                }

                public static class Wl
                {
                    private const string pre = Wayland.pre + "wl.";

                    public const string Wl_surface = pre + "wl_surface";
                }

            }

            public static class Win32
            {
                private const string pre = Create.pre + "win32.";

                public const string Hwnd = pre + "hwnd";

                public static class Pixel
                {
                    private const string pre = Win32.pre + "pixel.";

                    public static class Format
                    {
                        private const string pre = Pixel.pre + "format.";

                        public const string Pixel_format_hwnd = pre + "pixel_format_hwnd";
                    }

                }

            }

            public static class X11
            {
                private const string pre = Create.pre + "x11.";

                public const string Window = pre + "window";
            }

            public static class Emscripten
            {
                private const string pre = Create.pre + "emscripten.";

                public static class Canvas
                {
                    private const string pre = Emscripten.pre + "canvas.";

                    public const string Canvas_id = pre + "canvas_id";
                }

                public static class Keyboard
                {
                    private const string pre = Emscripten.pre + "keyboard.";

                    public const string Keyboard_element = pre + "keyboard_element";
                }

            }

            public static class Visionos
            {
                private const string pre = Create.pre + "visionos.";

                public const string Settings = pre + "settings";
            }

        }

        public static class Hdr
        {
            private const string pre = Window.pre + "hdr.";

            public const string Hdr_enabled = pre + "HDR_enabled";
            public const string Hdr_headroom = pre + "HDR_headroom";
        }

        public static class Sdr
        {
            private const string pre = Window.pre + "sdr.";

            public static class White
            {
                private const string pre = Sdr.pre + "white.";

                public const string Sdr_white_level = pre + "SDR_white_level";
            }

        }

        public static class Android
        {
            private const string pre = Window.pre + "android.";

            public const string Window_ = pre + "window";
            public const string Surface = pre + "surface";
        }

        public static class Uikit
        {
            private const string pre = Window.pre + "uikit.";

            public const string Window_ = pre + "window";

            public static class Metal
            {
                private const string pre = Uikit.pre + "metal.";

                public static class View
                {
                    private const string pre = Metal.pre + "view.";

                    public const string Metal_view_tag = pre + "metal_view_tag";
                }

            }

            public static class Opengl
            {
                private const string pre = Uikit.pre + "opengl.";

                public const string Framebuffer = pre + "framebuffer";
                public const string Renderbuffer = pre + "renderbuffer";

                public static class Resolve
                {
                    private const string pre = Opengl.pre + "resolve.";

                    public const string Resolve_framebuffer = pre + "resolve_framebuffer";
                }

            }

        }

        public static class Kmsdrm
        {
            private const string pre = Window.pre + "kmsdrm.";

            public static class Device
            {
                private const string pre = Kmsdrm.pre + "device.";

                public const string Dev_index = pre + "dev_index";
            }

            public static class Drm
            {
                private const string pre = Kmsdrm.pre + "drm.";

                public const string Drm_fd = pre + "drm_fd";
            }

            public static class Gbm
            {
                private const string pre = Kmsdrm.pre + "gbm.";

                public const string Gbm_dev = pre + "gbm_dev";
            }

        }

        public static class Cocoa
        {
            private const string pre = Window.pre + "cocoa.";

            public const string Window_ = pre + "window";

            public static class Metal
            {
                private const string pre = Cocoa.pre + "metal.";

                public static class View
                {
                    private const string pre = Metal.pre + "view.";

                    public const string Metal_view_tag = pre + "metal_view_tag";
                }

            }

        }

        public static class Openvr
        {
            private const string pre = Window.pre + "openvr.";

            public static class Overlay
            {
                private const string pre = Openvr.pre + "overlay.";

                public const string Overlay_id = pre + "overlay_id";
            }

        }

        public static class Qnx
        {
            private const string pre = Window.pre + "qnx.";

            public const string Window_ = pre + "window";
            public const string Surface = pre + "surface";
        }

        public static class Vivante
        {
            private const string pre = Window.pre + "vivante.";

            public const string Display = pre + "display";
            public const string Window_ = pre + "window";
            public const string Surface = pre + "surface";
        }

        public static class Win32
        {
            private const string pre = Window.pre + "win32.";

            public const string Hwnd = pre + "hwnd";
            public const string Hdc = pre + "hdc";
            public const string Instance = pre + "instance";
        }

        public static class Wayland
        {
            private const string pre = Window.pre + "wayland.";

            public const string Display = pre + "display";
            public const string Surface = pre + "surface";
            public const string Viewport = pre + "viewport";

            public static class Egl
            {
                private const string pre = Wayland.pre + "egl.";

                public const string Egl_window = pre + "egl_window";
            }

            public static class Xdg
            {
                private const string pre = Wayland.pre + "xdg.";

                public const string Xdg_surface = pre + "xdg_surface";
                public const string Xdg_toplevel = pre + "xdg_toplevel";
                public const string Xdg_popup = pre + "xdg_popup";
                public const string Xdg_positioner = pre + "xdg_positioner";

                public static class Toplevel
                {
                    private const string pre = Xdg.pre + "toplevel.";

                    public static class Export
                    {
                        private const string pre = Toplevel.pre + "export.";

                        public const string Xdg_toplevel_export_handle = pre + "xdg_toplevel_export_handle";
                    }

                }

            }

        }

        public static class X11
        {
            private const string pre = Window.pre + "x11.";

            public const string Display = pre + "display";
            public const string Screen = pre + "screen";
            public const string Window_ = pre + "window";
        }

        public static class Emscripten
        {
            private const string pre = Window.pre + "emscripten.";

            public static class Canvas
            {
                private const string pre = Emscripten.pre + "canvas.";

                public const string Canvas_id = pre + "canvas_id";
            }

            public static class Keyboard
            {
                private const string pre = Emscripten.pre + "keyboard.";

                public const string Keyboard_element = pre + "keyboard_element";
            }

        }

        public static class Visionos
        {
            private const string pre = Window.pre + "visionos.";

            public const string Settings = pre + "settings";
        }

    }
}