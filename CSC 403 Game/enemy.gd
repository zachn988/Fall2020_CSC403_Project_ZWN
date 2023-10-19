extends Sprite2D

@export var speed = 10
var screen_size
signal hit

# Called when the node enters the scene tree for the first time.
func _ready():
	screen_size = get_viewport_rect().size
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	var velocity = Vector2.ZERO
	var random_movement = randi()%6+1
	if random_movement == 1:
		velocity.x += 1
	elif random_movement == 2:
		velocity.z -= 1
	elif random_movement == 3:
		velocity.y += 1
	elif random_movement == 4:
		velocity.y -= 1
	else:
		pass

	if velocity.length() > 0:
		velocity = velocity.normalized() * speed

func start(pos):
	position = pos
	show()
