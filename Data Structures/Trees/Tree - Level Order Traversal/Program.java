void levelOrder(Node root) {
    if (root == null) {
        return;
    }

    Queue < Node > queue = new LinkedList < Node > ();
    queue.add(root);

    while (!queue.isEmpty()) {
        Node node = queue.remove();

        if (node.left != null) {
            queue.add(node.left);
        }

        if (node.right != null) {
            queue.add(node.right);
        }

        System.out.print(node.data + " ");
    }
}
