	function renderExercise(id){
		var $exerciseDiv = $("#exercisePartial");
		var url = $("#renderExerciseBtn" + id).attr('data-url');
		$.get(url, function(data) {
        	$exerciseDiv.replaceWith(data);	
        });
	}

(function($){
	
})(jQuery);