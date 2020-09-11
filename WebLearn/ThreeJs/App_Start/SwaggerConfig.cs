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
                        c.CustomProvider((defaultProvider) =>           //�Զ����ĵ��������޸�����������
                            new SwaggerControllerDescProvider(defaultProvider, xmlDesPath));
                        c.DocumentFilter<HiddenApiFilter>();            //�������API����
                        c.IncludeXmlComments(xmlDesPath);
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle(m_ProjectName);                 //�ĵ�����
                        c.InjectJavaScript(thisAssembly, "ThreeJs.Scripts.Swagger.swagger_lang.js"); //����
                    });
        }
        
        
    }
}
