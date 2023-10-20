extends TileMap

@export var enemyScene: PackedScene
# Called when the node enters the scene tree for the first time.
func _ready():
	new_game()
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
	
func _on_mob_timer_timeout():
	var enemy = enemyScene.instantiate()
	var enemySpawnLocation = get_node("enemyPath/enemySpawns")
	enemySpawnLocation.progress_ratio = randf()
	var direction = enemySpawnLocation.rotation + PI/2
	enemy.position = enemySpawnLocation.position
	add_child(enemy)
	
func new_game():
	$enemyTimer.start()
