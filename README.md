# NetFrameworkServer
Fork of NetCoreServer (.NET 5.0) for .NET Framework 4.7.2

## **Changes:**

***Added:***

 - **FrameworkUtil.ArrayRange:** Method to mimic the "range" operator to copy a range from an array

***Changed:***

 - Interface "**IWebSocket**" got the default method implementation removed. This feature isn't supported in .NET Framework. The default method bodies got just copy-pasted into the implementing classes.

***Removed:***

 - **HttpRequest.BodySpan**
- **HttpResponse.BodySpan**
- (type "Span" is not implemented in .NET Framework, you can just use the byte array property)