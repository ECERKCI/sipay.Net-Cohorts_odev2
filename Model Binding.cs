// Model
public class Product
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}

// Controller
[HttpGet]
public IActionResult Get([FromQuery] string name)
{
    // Query string üzerinden isim filtresine göre ürün listesini döndürme işlemi
}

[HttpPost]
public IActionResult Post([FromBody] Product product)
{
    // Yeni bir ürün eklemek için kullanılacak işlem
}

[HttpPut("{id}")]
public IActionResult Put(int id, [FromQuery] string name, [FromBody] Product product)
{
    // Bir ürünü güncellemek için kullanılacak işlem
}

[HttpDelete("{id}")]
public IActionResult Delete(int id, [FromQuery] string name)
{
    // Bir ürünü silmek için kullanılacak işlem
}

[HttpPatch("{id}")]
public IActionResult Patch(int id, [FromQuery] string name, [FromBody] JsonPatchDocument<Product> patchDoc)
{
    // Bir ürünün belirli alanlarını güncellemek için kullanılacak işlem
}
