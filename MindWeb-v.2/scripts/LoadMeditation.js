function renderDiv(url){
	$.get(url, function(data) {
			var div = $("#partialDiv");
       		div.replaceWith(data);	
		});
}
(function($){
	$(".categoryLi").on("click", "li", function(){
		var url = $(this).attr("data-url");
		renderDiv(url)
	});
	$(function() {	
		var url = $(".categoryLi > li").first().attr("data-url");
		renderDiv(url)
	});
})(jQuery);

