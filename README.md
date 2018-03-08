# GOGStoreQuery
Library to query the GOG game/movie store and parse the response into models that can be easily used.

## Usage
### Sync
```csharp
using GOGStoreQuery

string gameName = "Surviving Mars";

Models.Response response = Query.Search(gameName);
var firstResult = response.Products[0];
string responseMessage = $"GOG listing: {firstResult.Title} is available for ${firstResult.Price.FinalAmount}. You can find it here: https://gog.com/{firstResult.Url}";
// result: GOG listing: Surviving Mars - Pre-Order is available for $39.99. You can find it here: https://www.gog.com//game/surviving_mars
```

### Async
```csharp
using GOGStoreQuery

string gameName = "Surviving Mars";

Models.Response response = await Query.SearchAsync(gameName);
var firstResult = response.Products[0];
string responseMessage = $"GOG listing: {firstResult.Title} is available for ${firstResult.Price.FinalAmount}. You can find it here: https://gog.com/{firstResult.Url}";
// result: GOG listing: Surviving Mars - Pre-Order is available for $39.99. You can find it here: https://www.gog.com//game/surviving_mars
```

## Undocumented Endpoint
 - Limit cannot exceed 50
 - Game name needs to be url encoded
```csharp
https://www.gog.com/games/ajax/filtered?limit={limit}&search={gameName}
```
