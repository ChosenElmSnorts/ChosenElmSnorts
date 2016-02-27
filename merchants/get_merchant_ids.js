$(document).ready(function() {
    $.ajax({
        url: "http://api.reimaginebanking.com/enterprise/merchants?key=aa71fb9ed959b8325c48ad5b5892b755"
    }).then(function(data) {
		
	   var ids = '';
	   for(var i=0; i<data.results.length; i+=1) {
	     var merchant = data.results[i];
	     ids = ids.concat(merchant._id, "<br>");
	   }
	   $('.merchant-ids').append(ids);
	   
    });
});