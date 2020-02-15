extends HTTPRequest


# Declare member variables here. Examples:
# var a = 2
# var b = "text"


# Called when the node enters the scene tree for the first time.
func _ready():
	self.request("http://perdu.com");
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass


func _on_HTTPRequest_request_completed(result, response_code, headers, body):
	print(result)
	print(response_code)
	print(body)
	pass # Replace with function body.
