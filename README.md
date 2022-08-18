<p align="center"><img src="https://docs.keitaro.io/images/keitaro.png" /> </p>
<h1 align="center">
  Keitaro SDK .NET
</h1>
<p align="center">
<img src="https://img.shields.io/badge/USDT%20(TRC--20)-TBj6GqFVarSSBhfoS31WwZUp1xLN2NZgb1-red" />
</p>

Implementation of the [Keitaro API (v1)](https://admin-api.docs.keitaro.io/) for .NET

## Example

```csharp
var client = new KeitaroClient("api_token", "api_url");
var domains = await client.Domains.GetAll();
```

## Implementation

- [x] Domains
- [x] Campaigns
- [x] Affiliate Networks
- [x] Groups
- [x] Conversions
- [x] Clicks
- [x] Bots
- [x] Logs
- [x] Reports
- [ ] Offers
- [ ] Stats Clean
- [x] Streams
- [ ] Users
- [ ] Landing Pages

## TODO:
- [ ] Improve Filters for reports