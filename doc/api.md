<h1> Connecting to the API </h1>
BreweryDB's API offers 2 separate environments. Our sandbox environment can be found at https://sandbox-api.brewerydb.com/v2/. Our production environment can be found at https://api.brewerydb.com/v2/.

<h1> API Apps/Keys </h1>

API keys should be considered the same as a password. DO NOT share or distribute your key. Compromised keys will be disabled by our administrators.
Every request to the BreweryDB API requires an API key to be passed along with the request. Your API keys can be found and generated from the My Apps link under the "Developers" tab.


Every registered BreweryDB user who has agreed to our developer terms of service will automatically get one sandbox API key. This key will only have access to our sandbox environment.


Paid API subscribers will have the ability to create production API keys. Production API keys can only be used in our production environment.


Regardless of environment, our API expects your key to be passed via the URL with the key parameter. So if your key was abcdef, you would send a request to http://api.brewerydb.com/v2/{endpoint}/?key=abcdef.

<h1> Return Types </h1>
Our API offers 3 return types: JSON, XML and serialized PHP. Just like your API key, you can specify the return type by passing the format parameter in the query string of the request. The options you can pass are json, xml, or php. If you do not pass any format parameter, JSON will be returned.

You may also pass the format parameter by passing an option via the HTTP_ACCEPT header. You can pass application/json, application/xml, or text/php.

<h1>Sending Endpoint Arguments  </h1>
When sending data to BreweryDB, either for filtering on listing endpoints or for submitting new data, you should pass all your data using application/x-www-form-urlencoded strings. For GET methods, these are passed via the query string (after the "?" in the request URL). For POST and PUT methods, these should be passed in the POST body.

<h1> Request Limit </h1>
Each key has a request limit of 10,000 requests per day on the read methods. Write methods have no daily limit, meaning that you can write to our API as much as you want and it will not go against your request limit. The request counter resets every night at midnight Eastern Standard Time. If you need more requests than this, please contact us about our enterprise options.

We have a bandwidth rate limiting system in place to prevent abuse and system overload. If you receive a response code of 429, that means you have exceed the rate limit and you should send your requests at a slower rate. Our rate limits operate on a sliding window and are subject to the following restrictions:

•10 requests per second

•600 requests per minute

•6000 requests per hour

Note that these limits are current guidelines only and are subject to change without notice.

<h1> Status Values </h1>

All of the main attributes in BreweryDB (beers, breweries, guilds, events and locations) have status fields associated with them. Because BreweryDB is a curated service, these status fields give API users hints as to what state a given entity is in. The possible status values are:

Status: Description

Verified: Our staff has looked at the entity and has verified (to our best ability) the accuracy.

new_unverified:	When a new entity comes in, it gets the "new_unverified" status code until our moderation staff approves it, turning it to "verified".

update_pending:	If an update for the attribute or any of it's relationships comes in, it is set to "update_pending" until our staff verifies the change and integrates the changes. It's important to note that the actual change that was made is not updated on the entity until our staff verifies it. For example, if you renamed beer AAAAAA from "Budweiser" to "Bud", and then queried the API for beer AAAAAA, the name would still be "Budweiser" until our staff integrated the change. The status would be set as update_pending, but no actual change to the data would be made yet. Once our staff would verify the change, it would go back to "verified". These are also queued up, so multiple changes can be made and integrated by our staff.

delete_pending:	If we received a DELETE request for an entity, it would be set as "delete_pending" until our staff verified the entity should be deleted. Once we verify the deletion, the status is set to "deleted" and it is removed from all the search data.

deleted:	The entity is only able to be found by specifically requesting it by ID. It will not show up in any of the list or search endpoints at all.

