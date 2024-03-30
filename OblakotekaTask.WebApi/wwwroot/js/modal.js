function openModalToUpdate(parameters) {
    const id = parameters.data;
    const url = parameters.url;
    const modal = $('#modal');

    if (id == undefined && url === undefined) {
        alert('Something went wrong')
        return;
    }

    $.ajax({
        type: 'GET',
        url: url,
        data: { "id": id },
        success: function (response) {
            modal.find(".modal-body").html(response);
            modal.modal('show')
        },
        failure: function () {
            modal.modal('hide')
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
};


function openModalToCreate(parameters) {
    const url = parameters.url;
    const modal = $('#modal');

    if (url === undefined) {
        alert('Something went wrong')
        return;
    }

    $.ajax({
        type: 'GET',
        url: url,
        success: function (response) {
            modal.find(".modal-body").html(response);
            modal.modal('show')
        },
        failure: function () {
            modal.modal('hide')
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
};


//function submitForm() {
//    $.ajax({
//        url: '/Product/Update',
//        type: 'POST',
//        data: $('#modalFormId').serialize(),
//        success: function (response) {
//            // Проверяем, содержит ли ответ ошибки валидации
//            if ($(response).find('.field-validation-error').length > 0) {
//                // Обновляем модальное окно с частичным представлением с ошибками
//                $('#modalContent').html(response);
//            } else {
//                // Если ошибок нет, закрываем модальное окно или выполняем другие действия
//                $('#modal').modal('hide');
//            }
//        }
//    });
//}

//// Обработчик клика на кнопку "Сохранить"
//$('#updateProductBtnId').on('click', function (e) {
//    e.preventDefault();
//    submitForm();
//});