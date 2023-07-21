[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    // GET: api/products
    [HttpGet]
    public IActionResult Get()
    {
        // Ürün listesini döndürme işlemi
        // HTTP 200 ile başarılı sonuç dönmeli
    }

    // GET: api/products/{id}
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Belirli bir ürünün detaylarını döndürme işlemi
        // HTTP 200 ile başarılı sonuç dönmeli
        // Eğer ürün bulunamazsa HTTP 404 dönmeli
    }

    // POST: api/products
    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        // Yeni bir ürün eklemek için kullanılacak işlem
        // Gelen modelin zorunlu alanları kontrol edilmeli
        // HTTP 201 ile başarılı sonuç dönmeli
        // Eğer model geçerli değilse HTTP 400 dönmeli
    }

    // PUT: api/products/{id}
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Product product)
    {
        // Bir ürünü güncellemek için kullanılacak işlem
        // Gelen modelin zorunlu alanları kontrol edilmeli
        // HTTP 200 ile başarılı sonuç dönmeli
        // Eğer model geçerli değilse HTTP 400 dönmeli
        // Eğer güncellenecek ürün bulunamazsa HTTP 404 dönmeli
    }

    // DELETE: api/products/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Bir ürünü silmek için kullanılacak işlem
        // Eğer silinecek ürün bulunamazsa HTTP 404 dönmeli
        // HTTP 200 ile başarılı sonuç dönmeli
    }

    // PATCH: api/products/{id}
    [HttpPatch("{id}")]
    public IActionResult Patch(int id, [FromBody] JsonPatchDocument<Product> patchDoc)
    {
        // Bir ürünün belirli alanlarını güncellemek için kullanılacak işlem
        // Eğer güncellenecek ürün bulunamazsa HTTP 404 dönmeli
        // HTTP 200 ile başarılı sonuç dönmeli
    }
}
