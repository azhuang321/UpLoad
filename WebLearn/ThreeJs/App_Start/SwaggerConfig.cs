using System.Web.Http;
using WebActivatorEx;
using ThreeJs;
using Swashbuckle.Application;
using ThreeJs.App_Start;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace ThreeJs
{
    public class SwaggerConfig
    {
        private static string m_ProjectName = "ThreeJs";
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
            var xmlDesPath = string.Format("{0}/bin/ThreeJs.XML", System.AppDomain.CurrentDomain.BaseDirectory);


            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        
                        c.SingleApiVersion("v1", m_ProjectName);
                        c.IncludeXmlComments(xmlDesPath);
                        c.CustomProvider((defaultProvider) =>           //自定义文档描述，修复控制器描述
                            new SwaggerControllerDescProvider(defaultProvider, xmlDesPath));
                        c.DocumentFilter<HiddenApiFilter>();            //添加隐藏API特性
                        c.IncludeXmlComments(xmlDesPath);
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle(m_ProjectName);                 //文档标题
                        c.InjectJavaScript(thisAssembly, "ThreeJs.Scripts.Swagger.swagger_lang.js"); //汉化
                    });
        }
        
        
    }
}
