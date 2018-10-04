function excluir(id) {
	$.ajax({
		type: "DELETE",
		contentType: "application/json",
		url: '/User/Delete/' + id,
		success: function (data) {
			$('#modal-success').modal()
			$('.modal-title').html("Sucesso!")
			$('.modal-body').html(data.message);
		},
		error: function (data) {
			$('#modal-danger').modal();
			$('.modal-title').html("Erro!")
			$('.modal-body').html(data.message);
		}
	});
}