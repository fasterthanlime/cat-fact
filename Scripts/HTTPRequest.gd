extends HTTPRequest

# Called when the node enters the scene tree for the first time.
func _ready():
	var res = self.request("http://perdu.com");
	if res != OK:
		print("Could not make HTTP request {0}".format([res]))
	
	pass # Replace with function body.

func _process(delta):
	pass

func _on_HTTPRequest_request_completed(_result, _response_code, _headers, body_binary):
	var body = body_binary.get_string_from_utf8()
	get_node("../Label").text = body
	print(body)
	
