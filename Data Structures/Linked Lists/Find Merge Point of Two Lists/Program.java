int FindMergeNode(Node headA, Node headB) {
    Node node = new Node();

    while (headA != null) {
        node = headB;

        while (node != null) {
            if (headA == node) {
                return headA.data;
            }

            node = node.next;
        }

        headA = headA.next;
    }

    return 0;
}
