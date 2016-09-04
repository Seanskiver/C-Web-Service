$('#ajaxForm').submit(function(e) {
	// Stop form submission from refreshing the page
	e.preventDefault();

	// Text field values
	var first = $('#first').val();
	var second = $('#second').val();
	// plug in form values
	var parameters = {'first': first, 'second' : second};
	// Ajax start
	$.ajax({
		type: "POST",
		contentType: 'application/x-www-form-urlencoded',
		// Call web service url/ASP.NET web method
		url: "/MathApp/MyService.asmx/SumOfNums",
		dataType: 'xml',
		// Plug in the parameters object that contains the form values
		data: parameters,
		success: function(sum) {
			// Grab XML response object data and put it into the result div
			$('#result').html(sum.children[0].innerHTML);
		}
	});			
});
