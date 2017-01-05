using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RestServiceForPhp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductRestService" in both code and config file together.
    [ServiceContract]
    public interface IProductRestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "GetProductList/")]
        List<Product> GetProductList();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "GetProduct/{id}")]
        Product GetProductById(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "PostProduct/{id}")]
        bool NewProduct(string id, Product item);

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "PutProduct/{id}")]
        bool UpdatedProduct(string id, Product item);

        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "DeleteProduct/{id}")]
        bool DeleteProduct(string id);
    }
}