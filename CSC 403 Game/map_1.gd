extends TileMap

@export var enemyScene: PackedScene
var screen_size
# Called when the node enters the scene tree for the first time.
func _ready():
	screen_size = get_viewport_rect()
	new_game()
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
	
func _on_enemy_timer_timeout():
	var enemy = enemyScene.instantiate()
	var enemySpawnLocation = get_node("Marker2D")
	enemy.start(enemySpawnLocation.position)
	
func new_game():
	_on_enemy_timer_timeout()
