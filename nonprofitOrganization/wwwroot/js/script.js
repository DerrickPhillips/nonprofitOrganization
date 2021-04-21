"use strict"
function selectCardType() {
	var carNumValue = document.getElementById("ccNum").value
	var visa = /^4[0-9]{12}(?:[0-9]{3})?$/;
	var mc = /^5[1-5][0-9]{14}$/;
	var discover = /^6(?:011|5[0-9]{2})[0-9]{12}$/;
	var amex = /^3[47][0-9]{13}$/;

	var visaBox = document.getElementById("visa");
	var mcBox = document.getElementById("mc");
	var amexBox = document.getElementById("amex");
	var discoverBox = document.getElementById("discover");
	if (carNumValue != "" || carNumValue != null)
	{
		if (document.getElementById("visa").checked) {
			if (visa.test(carNumValue) != true) {
				alert("This is not a valid Visa card number");
				document.getElementById("cardV").value = "false";
			}
			else {
				document.getElementById("cardV").value = "true";
			}
		}
		else if (document.getElementById("mc").checked) {
			if (mc.test(carNumValue) != true) {
				alert("This is not a valid Master Card number");
				document.getElementById("cardV").value = "false";
			}
			else {
				document.getElementById("cardV").value = "true";
			}
		}
		else if (document.getElementById("discover").checked) {
			if (discover.test(carNumValue) != true) {
				alert("This is not a valid Discover card number");
				document.getElementById("cardV").value = "false";
			}
			else {
				document.getElementById("cardV").value = "true";
			}
		}
		else if (document.getElementById("amex").checked) {
			if (amex.test(carNumValue) != true) {
				alert("This is not a valid American Express card number");
				document.getElementById("cardV").value = "false";
			}
			else {
				document.getElementById("cardV").value = "true";
			}
		}
    }
}
function createEventListeners() {
	var carNum = document.getElementById("ccNum");
	var visa = document.getElementById("visa");
	var mc = document.getElementById("mc");
	var amex = document.getElementById("amex");
	var discover = document.getElementById("discover");

	if (carNum.addEventListener) {
		carNum.addEventListener("change", selectCardType, false);
	} else if (carNum.attachEvent) {
		carNum.attachEvent("onchange", selectCardType);
	}
	if (visa.addEventListener) {
		visa.addEventListener("change", selectCardType, false);
	} else if (visa.attachEvent) {
		visa.attachEvent("onchange", selectCardType);
	}
	if (mc.addEventListener) {
		mc.addEventListener("change", selectCardType, false);
	} else if (mc.attachEvent) {
		mc.attachEvent("onchange", selectCardType);
	}
	if (amex.addEventListener) {
		amex.addEventListener("change", selectCardType, false);
	} else if (amex.attachEvent) {
		amex.attachEvent("onchange", selectCardType);
	}
	if (discover.addEventListener) {
		discover.addEventListener("change", selectCardType, false);
	} else if (discover.attachEvent) {
		discover.attachEvent("onchange", selectCardType);
	}
}
if (window.addEventListener) {
	window.addEventListener("load", createEventListeners, false);
} else if (window.attachEvent) {
	window.attachEvent("onload", createEventListeners);
}