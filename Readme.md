# A Umbraco `ICacheRefresher` for SEO Checker so that it works with Umbraco v7.3 anonymous load balancing #

Umbraco v7.3+ doesn't use the umbracoSettings.config to list servers anymore, however SEO checker uses it to distribute changes to different servers, therefore changes made would only take effect on the current server until the application was restarted.

The solution was to create a custom `ICacheRefresher` so that a event can be subscribed to on all servers to clear the SEO checker cache. This was surprising easy once I had unpicked what was needed from the Umbraco core.

As SEO Checker doesn't have any event hooks for now I added a button in a custom dashboard to trigger the distributed call.

![](https://raw.githubusercontent.com/Jeavon/SEOCheckerCacheRefresher/master/docs/images/CustomButtons.PNG)

Umbraco login for the test site is u:admin, p:password