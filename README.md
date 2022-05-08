# Lehava.Tasks2
Working with tasks, async & await

Tasks Descriptions:
1. Create Task that generates 10 files (with random file name)
2. In each file write 10,000,000 '*' character
3. In UI create button that starts this action
4. In UI create new button with with label "Create 5 Threads"
5. When click this button It creates 5 Tasks of line Task 1 - Create Files Task #1 (in this way process will have 50 tasks that are run parallelly)
6. (For following instructions, please use Async Await uses)
7. In UI create new button with label "Create n Remove 10 files
8. When click this button it operates the following steps
	8.1. Create Task that generates one file (with random file name) contains 30,000,000 '*' character
	8.2 This task should return the full file name
	8.3 The caller will wait with await key-work and delete this file when 8.1 is finished
9. Now, we want to improve the 8.3 line and create special thread that deleting this big file
10. Add new Task that deletes the file, create this task only after Task from 8.1 has finished

