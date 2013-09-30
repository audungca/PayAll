﻿<!DOCTYPE html>
<html>
	<head>
		<title>@ViewBag.Title</title>
		<link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
		<link href="@Url.Content("~/Content/kendo/2013.2.716/kendo.common.min.css")" rel="stylesheet" type="text/css" />
	<link href="@Url.Content("~/Content/kendo/2013.2.716/kendo.dataviz.min.css")" rel="stylesheet" type="text/css" />
	<link href="@Url.Content("~/Content/kendo/2013.2.716/kendo.default.min.css")" rel="stylesheet" type="text/css" />
	<link href="@Url.Content("~/Content/kendo/2013.2.716/kendo.dataviz.default.min.css")" rel="stylesheet" type="text/css" />
	<script src="@Url.Content("~/Scripts/kendo/2013.2.716/jquery.min.js")"></script>
	<script src="@Url.Content("~/Scripts/kendo/2013.2.716/kendo.all.min.js")"></script>
	<script src="@Url.Content("~/Scripts/kendo/2013.2.716/kendo.aspnetmvc.min.js")"></script>
	<script src="@Url.Content("~/Scripts/kendo.modernizr.custom.js")"></script>
</head>
	<body>
		<header>
			<div class="content-wrapper">
				<div class="float-left">
					<p class="site-title">@Html.ActionLink("your logo here", "Index", "Home")</p>
				</div>
				<div class="float-right">
					<nav>
						<ul id="menu">
							<li>@Html.ActionLink("Home", "Index", "Home")</li>
							<li>@Html.ActionLink("About", "About", "Home")</li>
							<li>@Html.ActionLink("Contact", "Contact", "Home")</li>
						</ul>
					</nav>
				</div>
			</div>
		</header>
		<div id="body">
			@RenderSection("featured", required:= false)
			<section class="content-wrapper main-content clear-fix">
				@RenderBody()
			</section>
		</div>
		<footer>
			<div class="content-wrapper">
				<div class="float-left">
					<p>&copy; @DateTime.Now.Year - My KendoUI ASP.NET MVC Application</p>
				</div>
			</div>
		</footer>
	</body>
</html>
